using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ALMIR071023.Models;

namespace ALMIR071023.Controllers
{
    public class CelularesController : Controller
    {
        private readonly Contexto _context;

        public CelularesController(Contexto context)
        {
            _context = context;
        }

        // GET: Celulares
        public async Task<IActionResult> Index()
        {
              return View(await _context.Celulares.ToListAsync());
        }

        // GET: Celulares/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulares
                .FirstOrDefaultAsync(m => m.id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // GET: Celulares/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Celulares/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,marca")] Celular celular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(celular);
        }

        // GET: Celulares/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulares.FindAsync(id);
            if (celular == null)
            {
                return NotFound();
            }
            return View(celular);
        }

        // POST: Celulares/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,marca")] Celular celular)
        {
            if (id != celular.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelularExists(celular.id))
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
            return View(celular);
        }

        // GET: Celulares/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Celulares == null)
            {
                return NotFound();
            }

            var celular = await _context.Celulares
                .FirstOrDefaultAsync(m => m.id == id);
            if (celular == null)
            {
                return NotFound();
            }

            return View(celular);
        }

        // POST: Celulares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Celulares == null)
            {
                return Problem("Entity set 'Contexto.Celulares'  is null.");
            }
            var celular = await _context.Celulares.FindAsync(id);
            if (celular != null)
            {
                _context.Celulares.Remove(celular);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelularExists(int id)
        {
          return _context.Celulares.Any(e => e.id == id);
        }
    }
}
