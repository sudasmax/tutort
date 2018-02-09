using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.Mvc.Resources;
using Newtonsoft.Json;
using Tutort.SocialNetworks.Social.Interfaces;
using Tutort.Web.Models;
using Tutort.Web.ViewModels.Giveaway;
using Tutort.Web.ViewModels.Page;

namespace Tutort.Web.Controllers
{
	public class GiveawayController : PageController
	{
		public GiveawayController(ISocialIntegrationService socialIntegrationService)
			: base(socialIntegrationService)
		{
		}

		private string MakeLink(string url, string title)
		{
			return string.Format("<a href=\"{0}\">{1}</a>", url, title);
		}

		private string[] GenerateNavigationMenu(bool lastLink)
		{
			return new string[]
			{
				MakeLink(this.Url.Action("Index", "Home"), Localization.Header.MainMenu_Home),
				lastLink ? MakeLink(this.Url.Action("ShowGiveawayList", "Giveaway"), Localization.Giveaway.GiveawayList_Title) : Localization.Giveaway.GiveawayList_Title
			};
		}

		[OutputCache(Duration = 360, VaryByParam = "*")]
		public ActionResult ShowList()
		{
			var viewModel = new GiveawayListViewModel
			{
				HeadLine = new HeadLineViewModel
				{
					Title = Localization.Giveaway.GiveawayList_Title,
					NavigationMenuItems = this.GenerateNavigationMenu(false)
				},
				Items = new GiveawayItem[]
				{
					new GiveawayItem
					{
						Title = "Разыгрываем коробочку зефира",
						Image = "images/giveaway/20171112.jpg",
						Link = "giveaway/20171112",
						Date = "12.11.2017",
						IsActive = true
					},
					new GiveawayItem
					{
						Title = "30% скидка на торт",
						Image = "images/giveaway/20171022.jpg",
						Link = "giveaway/20171022",
						Date = "22.10.2017",
						IsActive = false
					},
					new GiveawayItem
					{
						Title = "Выиграй зефир себе и другу",
						Image = "images/giveaway/20171006.jpg",
						Link = "giveaway/20171006",
						Date = "06.10.2017",
						IsActive = false
					}
				}
			};

			return View("GiveawayList", viewModel);
		}

		//[OutputCache(Duration = 360, VaryByParam = "*")]
		public ActionResult Show(string key)
		{
			var viewModel = ContestData.FirstOrDefault(x => x.Date == key);

			if (viewModel != null)
			{
				viewModel.HeadLine = new HeadLineViewModel
				{
					Title = Localization.Giveaway.Giveaway_Title,
					NavigationMenuItems = this.GenerateNavigationMenu(true)
				};

				var fileName = Server.MapPath(string.Format("~/App_Data/giveaway/{0}.json", viewModel.Date));
				var comments = DeserializeFromStream<List<Comment>>(fileName);

				viewModel.Participants = comments
					.GroupBy(x => x.Autor)
					.Select(x => new GiveawayParticipantViewModel
						{
							InstagramUser = x.Key,
							Comments = x.Select(y => new GiveawayComment { Comment = y.Message, ReferencedAccounts = y.ReferencedAccounts.ToArray() }).ToArray(),
						})
					.OrderByDescending(x => x.Comments.Length)
					.ToArray();

				return View("Giveaway", viewModel);
			}

			return RedirectToAction("ShowList", "Giveaway");
		}

		[HttpPost]
		public ActionResult SelectWinner(string key)
		{
			var viewModel = ContestData.FirstOrDefault(x => x.Date == key);

			if (viewModel != null)
			{
				var fileName = Server.MapPath(string.Format("~/App_Data/giveaway/{0}.json", viewModel.Date));
				var comments = DeserializeFromStream<List<Comment>>(fileName);

				Random rnd = new Random(DateTime.Now.Millisecond);
				int r = rnd.Next(comments.Count);

				var winner = new GiveawayParticipantViewModel
				{
					InstagramUser = comments[r].Autor,
					Comments = new GiveawayComment[] { new GiveawayComment { Comment = comments[r].Message, ReferencedAccounts = comments[r].ReferencedAccounts.ToArray() } }
				};

				return PartialView("Winner", winner);
			}

			throw new HttpException(404, "Розыгрыш не найден.");
		}

		private T DeserializeFromStream<T>(string file)
		{
			var serializer = new JsonSerializer();

			using (var sr = new StreamReader(file))
			using (var jsonTextReader = new JsonTextReader(sr))
			{
				return serializer.Deserialize<T>(jsonTextReader);
			}
		}

		private GiveawayViewModel[] ContestData = new GiveawayViewModel[]
		{
			new GiveawayViewModel
			{
				Date = "20171112",
				IsActive = true,
				Info = "Садимся поудобнее, гладим 3 минуты экран телефона и верим в удачу наши преданные сладкоежки! Просто👍🏼Вкусно👌🏼Бесплатно🙌🏼 Сегодня разыгрываем коробочку 🎁воздушного и ароматного 🍥 ЗЕФИРА!!!",
				Details = "Победителя выберем в воскресенье 12 ноября в 12-00 с помощью генератора случайных чисел, видео розыгрыша смотрите в 📹 сториз, 😍 Можете оставлять любое количество комментариев, НО, вписывать новых друзей❗ (не повторять аккаунты ранее указанных друзей) ❤️ Желаем всем удачи в конкурсе ❤️",
				Rules = new GiveawayRule[]
				{
					new GiveawayRule
					{
						Title = "Быть подписчиком",
						Class = "fa fa-pencil",
						Text = "Нужно быть подписанным на наш аккаунт в инстаграмм."
					},
					new GiveawayRule
					{
						Title = "Поставить три лайка",
						Class = "fa fa-heart",
						Text = "Нужно поставить 3 лайка к трем последним постам (сам пост о розыгрыше и два предыдущих поста)."
					},
					new GiveawayRule
					{
						Title = "Указать порядоковый номер и друга",
						Class = "fa fa-bullhorn",
						Text = "Нужно указать в комментариях двух своих друзей (через @) и следующий по порядку номер. Следите, чтобы номер не повторялся!"
					}
				}
			},
			new GiveawayViewModel
			{
				Date = "20171006",
				IsActive = false,
				Info = "Ниже показаны наши посты в инстаграмм, которые участвую в розыгрыше. Как минимум на трех из указанных ниже постов, должен стоять лайк от участника, чтобы участие было подтверждено программой. Будьте внимательны и перепроверьте все ли условия участия соблюдены с вашей стороны.",
				Details = "По результатам розыгрыша победивший игрок получит коробочку Зефира Ассорти на 8шт. Человек, указанный в победившем комментарии, получит коробочку зефира на 6шт. По окончании розыгрыша организаторы свяжутся с победителями посредством Инстаграмм и договорятся о месте передачи приза.",
				Rules = new GiveawayRule[]
				{
					new GiveawayRule
					{
						Title = "Быть подписчиком",
						Class = "fa fa-pencil",
						Text = "Нужно быть подписанным на наш аккаунт в инстаграмм."
					},
					new GiveawayRule
					{
						Title = "Указать друга",
						Class = "fa fa-bullhorn",
						Text = "Нужно указать в комментариях одного cвоего друга (через @)."
					},
					new GiveawayRule
					{
						Title = "Поставить три лайка",
						Class = "fa fa-heart",
						Text = "Нужно поставить 3 лайка к трем последним постам (сам пост о розыгрыше и два предыдущих поста)."
					}
				},
				Winner = new GiveawayParticipantViewModel
				{
					InstagramUser = "VITALIKKORSHUK",
					Comments = new GiveawayComment[] { new GiveawayComment { Comment = "@alakorshuk" } }
				}
			},
			new GiveawayViewModel
			{
				Date = "20171022",
				IsActive = false,
				Info = "На этот раз размер приза 🎁 зависит только от вас!!! При заказе торта мы дарим вам 30% от полной его стоимости!!! Чем больше торт, тем больше вы экономите 💰!!! Желаем всем удачи в конкурсе, порадуйте себя, экономия должна быть экономной ❤",
				Details = "Победителя выберем в воскресенье 22 октября с 20-00 до 21-00 с помощью генератора случайных чисел, видео розыгрыша смотрите в 📹 сториз, 😍 Можете оставлять любое количество комментариев, НО, вписывать новых друзей❗ (не повторять аккаунты ранее указанных друзей) ❤",
				Rules = new GiveawayRule[]
				{
					new GiveawayRule
					{
						Title = "Быть подписчиком",
						Class = "fa fa-pencil",
						Text = "Нужно быть подписанным на наш аккаунт в инстаграмм."
					},
					new GiveawayRule
					{
						Title = "Указать друга",
						Class = "fa fa-bullhorn",
						Text = "Нужно указать в комментариях одного cвоего друга (через @)."
					},
					new GiveawayRule
					{
						Title = "Поставить пять лайков",
						Class = "fa fa-heart",
						Text = "Нужно поставить лайки к 5 последним постам."
					}
				},
				Winner = new GiveawayParticipantViewModel
				{
					InstagramUser = "yulia_medovskaia",
					Comments = new GiveawayComment[] { new GiveawayComment { Comment = "@malykha_trulyalya" } }
				}
			}
		};
	}
}