using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ComponentsViewModels.Index
{
    public class IndexVm
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> NewArrival { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Featured { get; set; }
    }
}
