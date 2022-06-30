using Imtahan.DAL;
using Imtahan.ViewModels.HomeVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            HomeVM home = new HomeVM
            {
                Hero = await _context.Heroes.FirstOrDefaultAsync(),
                Services = await _context.Services.ToListAsync(),
                Clients = await _context.Clients.ToListAsync(),
                Settings = await _context.Settings.ToListAsync(),
            };
            return View(home);
        }
    }
}
