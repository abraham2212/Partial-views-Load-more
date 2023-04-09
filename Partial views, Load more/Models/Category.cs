namespace PurpleBuzz.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Filter { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
