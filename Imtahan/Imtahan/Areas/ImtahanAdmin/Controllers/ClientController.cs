using Imtahan.DAL;
using Imtahan.Models;
using Imtahan.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imtahan.Areas.ImtahanAdmin.Controllers
{
    [Area("ImtahanAdmin")]
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ClientController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients = await _context.Clients.ToListAsync();
            return View(clients);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Client client = await _context.Clients.FirstOrDefaultAsync(p=>p.Id==id);
            return View(client);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Create(Client client)
        {
            if (!ModelState.IsValid) return View();
            if (client.Photo != null)
            {
                if (client.Photo.Length<1024*1024 && client.Photo.ContentType.Contains("image"))
                {
                    client.Image = await client.Photo.FileCreate(_env.WebRootPath,@"assets\IMG\client-image");
                    await _context.Clients.AddAsync(client);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Please choose correct choses");
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Please choose photo");
                return View();
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            Client client = await _context.Clients.FirstOrDefaultAsync(p => p.Id == id);
            if (client.Id != null) return View();
            return View(client);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(int id,Client client)
        {
            if (!ModelState.IsValid) return View();

            Client existedClient = await _context.Clients.FirstOrDefaultAsync(p => p.Id == id);

            if (existedClient.Id !=id) return NotFound();
            if (client.Photo != null)
            {
                if (client.Photo.Length < 1024 * 1024 && client.Photo.ContentType.Contains("image"))
                {
                    client.Image = await client.Photo.FileCreate(_env.WebRootPath, @"assets\IMG\client-image");
                    _context.Entry(existedClient).CurrentValues.SetValues(client);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", "Please choose correct choses");
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Please choose photo");
                return View();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            Client client = await _context.Clients.FirstOrDefaultAsync(p => p.Id == id);
 
            return View(client);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            Client client = await _context.Clients.FirstOrDefaultAsync(p => p.Id == id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
