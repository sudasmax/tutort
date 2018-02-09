using System;

namespace Tutort.Web.ViewModels.Social.Instagram
{
	public class InstagramPostViewModel
	{
		public string Description { get; set; }
		public ImageViewModel Image { get; set; }
		public DateTime Date { get; set; }

		public string Url { get; set; }
	}
}