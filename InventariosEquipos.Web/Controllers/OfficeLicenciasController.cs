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
    public class OfficeLicenciasController : Controller
    {
        private readonly DataContext _context;

        public OfficeLicenciasController(DataContext context)
        {
            _context = context;
        }

        // GET: OfficeLicencias
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfficeLicencias.ToListAsync());
        }

        // GET: OfficeLicencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLicencia = await _context.OfficeLicencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeLicencia == null)
            {
                return NotFound();
            }

            return View(officeLicencia);
        }

        // GET: OfficeLicencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OfficeLicencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LicenciaOffice")] OfficeLicencia officeLicencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(officeLicencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(officeLicencia);
        }

        // GET: OfficeLicencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLicencia = await _context.OfficeLicencias.FindAsync(id);
            if (officeLicencia == null)
            {
                return NotFound();
            }
            return View(officeLicencia);
        }

        // POST: OfficeLicencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LicenciaOffice")] OfficeLicencia officeLicencia)
        {
            if (id != officeLicencia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(officeLicencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeLicenciaExists(officeLicencia.Id))
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
            return View(officeLicencia);
        }

        // GET: OfficeLicencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLicencia = await _context.OfficeLicencias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (officeLicencia == null)
            {
                return NotFound();
            }

            return View(officeLicencia);
        }

        // POST: OfficeLicencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var officeLicencia = await _context.OfficeLicencias.FindAsync(id);
            _context.OfficeLicencias.Remove(officeLicencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfficeLicenciaExists(int id)
        {
            return _context.OfficeLicencias.Any(e => e.Id == id);
        }
    }
}
