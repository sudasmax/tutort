using Tutort.Web.ViewModels.Shared;

namespace Tutort.Web.ViewModels.Giveaway
{
    public class GiveawayViewModel : PageViewModel
    {
        public bool IsActive { get; set; }
        public string Date { get; set; }
        public GiveawayRule[] Rules { get; set; }
        public GiveawayParticipantViewModel[] Participants { get; set; }
        public GiveawayParticipantViewModel Winner { get; set; }
        public string Info { get; set; }
        public string Details { get; set; }
    }
}