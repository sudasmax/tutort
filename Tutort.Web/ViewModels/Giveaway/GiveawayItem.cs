using System;

namespace Tutort.Web.ViewModels.Giveaway
{
    public class GiveawayItem
    {
        public string Link { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }

        public bool IsActive { get; set; }
    }
}