using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BrandController : Controller
    {
        
        private readonly AppDbContext _context;
        
        public BrandController(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.Where(b=>b.IsDeleted==false).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult>Create(MyClass myClass)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return Content(myClass.Test);
        }

        public class MyClass
        {
            public string Test { get; set; }
            public string Email { get; set; }
            public string Passworld { get; set; }
        }

       
    }
}
