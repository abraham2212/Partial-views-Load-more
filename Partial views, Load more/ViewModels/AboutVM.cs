using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class AboutVM
    {
        public Banner Banner { get; set; }
        public TeamMemberHeader TeamMemberHeader { get; set; }
        public WhyUsBanner WhyUsBanner { get; set; }
        public Subscribe Subscribe { get; set; }

        public IEnumerable<TeamMember> TeamMembers { get; set; }
        public IEnumerable<ObjectiveBanner> ObjectiveBanners { get; set; }
        public IEnumerable<Partner> Partners { get; set; }
    }
}
