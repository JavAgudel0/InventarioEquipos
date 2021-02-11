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
    public class LicenciasSistemasOperativosController : Controller
    {
        private readonly DataContext _context;

        public LicenciasSistemasOperativosController(DataContext context)
        {
            _context = context;
        }

        // GET: LicenciasSistemasOperativos
        public async Task<IActionResult> Index()
        {
            return View(await _context.LicenciasSistemasOperativos.ToListAsync());
        }

        // GET: LicenciasSistemasOperativos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenciaSistemaOperativo = await _context.LicenciasSistemasOperativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licenciaSistemaOperativo == null)
            {
                return NotFound();
            }

            return View(licenciaSistemaOperativo);
        }

        // GET: LicenciasSistemasOperativos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LicenciasSistemasOperativos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Licencia")] LicenciaSistemaOperativo licenciaSistemaOperativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licenciaSistemaOperativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licenciaSistemaOperativo);
        }

        // GET: LicenciasSistemasOperativos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenciaSistemaOperativo = await _context.LicenciasSistemasOperativos.FindAsync(id);
            if (licenciaSistemaOperativo == null)
            {
                return NotFound();
            }
            return View(licenciaSistemaOperativo);
        }

        // POST: LicenciasSistemasOperativos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Licencia")] LicenciaSistemaOperativo licenciaSistemaOperativo)
        {
            if (id != licenciaSistemaOperativo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licenciaSistemaOperativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenciaSistemaOperativoExists(licenciaSistemaOperativo.Id))
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
            return View(licenciaSistemaOperativo);
        }

        // GET: LicenciasSistemasOperativos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var licenciaSistemaOperativo = await _context.LicenciasSistemasOperativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licenciaSistemaOperativo == null)
            {
                return NotFound();
            }

            return View(licenciaSistemaOperativo);
        }

        // POST: LicenciasSistemasOperativos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var licenciaSistemaOperativo = await _context.LicenciasSistemasOperativos.FindAsync(id);
            _context.LicenciasSistemasOperativos.Remove(licenciaSistemaOperativo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenciaSistemaOperativoExists(int id)
        {
            return _context.LicenciasSistemasOperativos.Any(e => e.Id == id);
        }
    }
}
