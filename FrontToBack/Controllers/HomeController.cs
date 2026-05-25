using FrontToBack.Data;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            
            var services = await _context.Services.ToListAsync();

           
            HomeVM homeVM = new HomeVM
            {
                Services = services
            };

           
            return View(homeVM);
        }
    }
}