using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class PricingVM
    {
        public IEnumerable<PricingTitle> PricingTitles { get; set; }
        public PricingHeader PricingHeader { get; set; }
    }
}
