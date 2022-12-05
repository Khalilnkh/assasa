using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ComponentsViewModels.Index;
using WebApplication1.DAL;

namespace WebApplication1.ViewComponents
{
    public class IndexViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public IndexViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            

            IndexVm indexVm = new IndexVm
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync(),
                NewArrival = await _context.Products.Where(p => p.IsDeleted == false && p.IsNewArrival == true).ToListAsync(),
                BestSeller = await _context.Products.Where(p => p.IsDeleted == false && p.IsBestSeller == true).ToListAsync(),
                Featured = await _context.Products.Where(p => p.IsDeleted == false && p.IsFeatured == true).ToListAsync()

            };
            return View(await Task.FromResult(indexVm));
        }
    }
}
