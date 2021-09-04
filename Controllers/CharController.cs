using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aueba.Models;

namespace aueba.Controllers
{
    public class CharController : Controller
    {
        private readonly Context _context;

        public CharController(Context context)
        {
            _context = context;
        }

        // GET: Char
        public async Task<IActionResult> Index()
        {
            return View(await _context.Char.ToListAsync());
        }

        // GET: Char/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @char = await _context.Char
                .FirstOrDefaultAsync(m => m.CharID == id);
            if (@char == null)
            {
                return NotFound();
            }

            return View(@char);
        }

        // GET: Char/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Char/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CharID,CharName,CharDex,CharHP")] Models.Char @char)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@char);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@char);
        }

        // GET: Char/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @char = await _context.Char.FindAsync(id);
            if (@char == null)
            {
                return NotFound();
            }
            return View(@char);
        }

        // POST: Char/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CharID,CharName,CharDex,CharHP")] Models.Char @char)
        {
            if (id != @char.CharID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@char);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharExists(@char.CharID))
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
            return View(@char);
        }

        // GET: Char/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @char = await _context.Char
                .FirstOrDefaultAsync(m => m.CharID == id);
            if (@char == null)
            {
                return NotFound();
            }

            return View(@char);
        }

        // POST: Char/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @char = await _context.Char.FindAsync(id);
            _context.Char.Remove(@char);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharExists(int id)
        {
            return _context.Char.Any(e => e.CharID == id);
        }
    }
}
