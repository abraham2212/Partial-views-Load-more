using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<SliderInfo> SliderInfos { get; set; }
        public IEnumerable<Work> Works { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public SliderImage SliderImage { get; set; }
        public Service Service { get; set; }
    }
}
