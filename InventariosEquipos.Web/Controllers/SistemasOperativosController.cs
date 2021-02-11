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
    public class SistemasOperativosController : Controller
    {
        private readonly DataContext _context;

        public SistemasOperativosController(DataContext context)
        {
            _context = context;
        }

        // GET: SistemasOperativos
        public async Task<IActionResult> Index()
        {
            return View(await _context.SistemasOperativos.ToListAsync());
        }

        // GET: SistemasOperativos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemaOperativo = await _context.SistemasOperativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sistemaOperativo == null)
            {
                return NotFound();
            }

            return View(sistemaOperativo);
        }

        // GET: SistemasOperativos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SistemasOperativos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreSistemaOperativo")] SistemaOperativo sistemaOperativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sistemaOperativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sistemaOperativo);
        }

        // GET: SistemasOperativos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemaOperativo = await _context.SistemasOperativos.FindAsync(id);
            if (sistemaOperativo == null)
            {
                return NotFound();
            }
            return View(sistemaOperativo);
        }

        // POST: SistemasOperativos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreSistemaOperativo")] SistemaOperativo sistemaOperativo)
        {
            if (id != sistemaOperativo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sistemaOperativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SistemaOperativoExists(sistemaOperativo.Id))
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
            return View(sistemaOperativo);
        }

        // GET: SistemasOperativos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sistemaOperativo = await _context.SistemasOperativos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sistemaOperativo == null)
            {
                return NotFound();
            }

            return View(sistemaOperativo);
        }

        // POST: SistemasOperativos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sistemaOperativo = await _context.SistemasOperativos.FindAsync(id);
            _context.SistemasOperativos.Remove(sistemaOperativo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SistemaOperativoExists(int id)
        {
            return _context.SistemasOperativos.Any(e => e.Id == id);
        }
    }
}
