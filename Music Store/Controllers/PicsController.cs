using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Music_Store.Models;

namespace Music_Store.Controllers
{
    public class PicsController : Controller
    {
        private readonly DbContextDemo _context;

        public PicsController(DbContextDemo context)
        {
            _context = context;
        }

        // GET: Pics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pics.ToListAsync());
        }
        public IActionResult Index2()
        {
            return View(_context.Pics.ToList());
        }
        // GET: Pics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pic = await _context.Pics
                .FirstOrDefaultAsync(m => m.PicId == id);
            if (pic == null)
            {
                return NotFound();
            }

            return View(pic);
        }

        // GET: Pics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PicId,PicName,GiaTien,TieuDe")] Pic pic)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pic);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pic);
        }

        // GET: Pics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pic = await _context.Pics.FindAsync(id);
            if (pic == null)
            {
                return NotFound();
            }
            return View(pic);
        }

        // POST: Pics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PicId,PicName,GiaTien,TieuDe")] Pic pic)
        {
            if (id != pic.PicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PicExists(pic.PicId))
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
            return View(pic);
        }

        // GET: Pics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pic = await _context.Pics
                .FirstOrDefaultAsync(m => m.PicId == id);
            if (pic == null)
            {
                return NotFound();
            }

            return View(pic);
        }

        // POST: Pics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pic = await _context.Pics.FindAsync(id);
            _context.Pics.Remove(pic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PicExists(int id)
        {
            return _context.Pics.Any(e => e.PicId == id);
        }
    }
}
