namespace PurpleBuzz.Models
{
    public class PricingOffer : BaseEntity
    {
        public string Offer { get; set; }
        public int PricingTitleId { get; set; }
        public PricingTitle PricingTitle { get; set; }
    }
}
