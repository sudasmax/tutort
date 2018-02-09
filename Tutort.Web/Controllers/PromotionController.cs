using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Tutort.Web.Models;
using Tutort.Web.Models.ViewModels.Promotion;

namespace Tutort.Web.Controllers
{
	public class PromotionController : Controller
	{
		private T DeserializeFromStream<T>(string file)
		{
			var serializer = new JsonSerializer();

			using (var sr = new StreamReader(file))
			using (var jsonTextReader = new JsonTextReader(sr))
			{
				return serializer.Deserialize<T>(jsonTextReader);
			}
		}

		private List<Comment> _messages;
		private List<Comment> Messages
		{
			get
			{
				if (_messages == null)
				{
					var fileName = Server.MapPath("~/App_Data/list.json");
					var comments = DeserializeFromStream<List<Comment>>(fileName);

					_messages = comments.Where(x => x.ReferencedAccounts.Count == 1).ToList();
				}

				return _messages;
			}
		}

		private Dictionary<string, List<Comment>> _data;
		private Dictionary<string, List<Comment>> Data
		{
			get
			{
				if (_data == null)
				{
					_data = Messages
						.GroupBy(x => x.Autor)
						.OrderByDescending(x => x.Count())
						.ToDictionary(x => x.Key, x => x.ToList());
				}

				return _data;
			}
		}


		// GET: Promotion
		public ActionResult Index()
		{
			var viewModel = new PromoViewModel();

			viewModel.CommentsByAuthor = Data;

			viewModel.Winner = new PromoWinnerViewModel { Winner = Messages.First(x => x.Autor == "vitalikkorshuk") };

			return View(viewModel);
		}

		[HttpPost]
		public ActionResult GetWinner()
		{
			var viewModel = new PromoWinnerViewModel();

			Random rnd = new Random(DateTime.Now.Millisecond);
			int r = rnd.Next(Messages.Count);

			viewModel.Winner = Messages[r];

			return PartialView("PromoWinner", viewModel);
		}
	}
}