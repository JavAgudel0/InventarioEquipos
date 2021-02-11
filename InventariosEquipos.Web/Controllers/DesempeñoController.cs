using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventariosEquipos.Web.Data;
using InventariosEquipos.Web.Data.Entities;

namespace InventariosEquipos.Web.Controllers
{
    public class DesempeñoController : Controller
    {
        private readonly DataContext _context;

        public DesempeñoController(DataContext context)
        {
            _context = context;
        }

        // GET: Desempeño
        public async Task<IActionResult> Index()
        {
            return View(await _context.Desempeños.ToListAsync());
        }

        // GET: Desempeño/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempeño = await _context.Desempeños
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desempeño == null)
            {
                return NotFound();
            }

            return View(desempeño);
        }

        // GET: Desempeño/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Desempeño/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreDesempeño")] Desempeño desempeño)
        {
            if (ModelState.IsValid)
            {
                _context.Add(desempeño);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(desempeño);
        }

        // GET: Desempeño/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempeño = await _context.Desempeños.FindAsync(id);
            if (desempeño == null)
            {
                return NotFound();
            }
            return View(desempeño);
        }

        // POST: Desempeño/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreDesempeño")] Desempeño desempeño)
        {
            if (id != desempeño.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desempeño);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesempeñoExists(desempeño.Id))
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
            return View(desempeño);
        }

        // GET: Desempeño/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desempeño = await _context.Desempeños
                .FirstOrDefaultAsync(m => m.Id == id);
            if (desempeño == null)
            {
                return NotFound();
            }

            return View(desempeño);
        }

        // POST: Desempeño/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var desempeño = await _context.Desempeños.FindAsync(id);
            _context.Desempeños.Remove(desempeño);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesempeñoExists(int id)
        {
            return _context.Desempeños.Any(e => e.Id == id);
        }
    }
}
