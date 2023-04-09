namespace PurpleBuzz.Models
{
    public class PricingTitle : BaseEntity
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public ICollection<PricingOffer> PricingOffers { get; set; }
    }
}
