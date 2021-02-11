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
    public class UsosController : Controller
    {
        private readonly DataContext _context;

        public UsosController(DataContext context)
        {
            _context = context;
        }

        // GET: Usos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usos.ToListAsync());
        }

        // GET: Usos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uso = await _context.Usos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uso == null)
            {
                return NotFound();
            }

            return View(uso);
        }

        // GET: Usos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreUso")] Uso uso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uso);
        }

        // GET: Usos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uso = await _context.Usos.FindAsync(id);
            if (uso == null)
            {
                return NotFound();
            }
            return View(uso);
        }

        // POST: Usos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreUso")] Uso uso)
        {
            if (id != uso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsoExists(uso.Id))
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
            return View(uso);
        }

        // GET: Usos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uso = await _context.Usos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (uso == null)
            {
                return NotFound();
            }

            return View(uso);
        }

        // POST: Usos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uso = await _context.Usos.FindAsync(id);
            _context.Usos.Remove(uso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsoExists(int id)
        {
            return _context.Usos.Any(e => e.Id == id);
        }
    }
}
