using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePetStoreInfoAPI.Models;
using OnlinePetStoreInfoAPI.Services;

namespace OnlinePetStoreInfoAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly PetStoreDBContext _context;

        public HomeController(PetStoreDBContext context)
        {

            _context = context;

        }

        public async Task<IActionResult> Index()
        {
             return View(await _context.Stores.ToListAsync());
            //return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreId, StoreName, StoreDescription, StoreAddress")] PetStoreModel petstore)
        {
            if(ModelState.IsValid)
            {
                _context.Add(petstore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(petstore);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petStore = await _context.Stores.FindAsync(id);
            if (petStore == null)
            {
                return NotFound();
            }
            return View(petStore);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StoreId, StoreName, StoreDescription, StoreAddress")] PetStoreModel petstore)
        {
            if (id != petstore.StoreId)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(petstore);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!StoreExist(petstore.StoreId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(petstore);
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var petstore = await _context.Stores
                .FirstOrDefaultAsync(m => m.StoreId == id);
            if (petstore == null)
            {
                return NotFound();
            }

            return View(petstore);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var petstore = await _context.Stores.FindAsync(id);
            _context.Stores.Remove(petstore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool StoreExist(int id)
        {
            return _context.Stores.Any(s => s.StoreId == id);
        }
    }
}
