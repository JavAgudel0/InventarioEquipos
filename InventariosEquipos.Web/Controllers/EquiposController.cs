﻿using InventariosEquipos.Web.Data;
using InventariosEquipos.Web.Data.Entities;
using InventariosEquipos.Web.Helpers;
using InventariosEquipos.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Controllers
{
    public class EquiposController : Controller
    {
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;
        private readonly IConverterHelper _converterHelper;

        public EquiposController(
            DataContext context,
            ICombosHelper comboshelper,
            IConverterHelper converterHelper)
        {
            _context = context;
            _combosHelper = comboshelper;
            _converterHelper = converterHelper;
        }

        // GET: Equipos
        public async Task<IActionResult> Index()
        {
            return View(_context.Equipos
            .Include(o => o.Estado)
            .Include(o => o.Sucursal)
            .Include(o => o.Marca));

            //return View(await _context.Equipos.ToListAsync());
        }

        // GET: Equipos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Equipo equipo = await _context.Equipos.
                Include(e => e.Sucursal).
                Include(e => e.Uso).
                Include(e => e.SistemaOperativo).
                Include(e => e.Estado).
                Include(e => e.LicenciaSistemaOperativo).
                Include(e => e.OfficeLicencia).
                Include(e => e.Marca).
                Include(e => e.Color).
                Include(e => e.Desempeno)
                
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // GET: Equipos/Create---------------------------------------------------
        public IActionResult Create()
        {
            EquipoViewModel model = new EquipoViewModel
            {
                Colores = _combosHelper.GetComboColores(),
                Marcas = _combosHelper.GetComboMarcas(),
                Desempenos = _combosHelper.GetComboDesempenos(),
                Usos = _combosHelper.GetComboUsos(),
                Sucursales = _combosHelper.GetComboSucursales(),
                Estados = _combosHelper.GetComboEstados(),
                SistemasOperativos = _combosHelper.GetComboSistemasOperativos(),
                OfficeLicencias = _combosHelper.GetComboOfficeLicencias(),
                LicenciasSistemasOperativos = _combosHelper.GetComboLicenciasSistemasOperativos()
            };

            return View(model);
        }

        // POST: Equipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EquipoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var equipo = await _converterHelper.ToEquipoAsync (model);
                _context.Equipos.Add(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Index");

                //_context.Add(equipo);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        

        // GET: Equipos/Edit/5---------------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipos.
                Include(e => e.Sucursal).
                Include(e => e.Uso).
                Include(e => e.SistemaOperativo).
                Include(e => e.Estado).
                Include(e => e.LicenciaSistemaOperativo).
                Include(e => e.OfficeLicencia).
                Include(e => e.Marca).
                Include(e => e.Color).
                Include(e => e.Desempeno).
                FirstOrDefaultAsync(e => e.Id == id);
           
            if (equipo == null)
            {
                return NotFound();
            }
            return View(_converterHelper.ToEquipoViewModel(equipo));
        }

        // POST: Equipos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (EquipoViewModel model)
        {

            if (ModelState.IsValid)
            {
                var equipo = await _converterHelper.ToEquipoAsync(model);
                _context.Equipos.Update(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details/{model.Id}");
                //try
                //{
                //    _context.Update(equipo);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!EquipoExists(equipo.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                //return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Equipos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Equipo equipo = await _context.Equipos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Equipo equipo = await _context.Equipos.FindAsync(id);
            _context.Equipos.Remove(equipo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipos.Any(e => e.Id == id);
        }



        //public IActionResult AddEquipo(int? id)
        //{

        //    EquipoViewModel model = new EquipoViewModel
        //    {
        //        Colores = _combosHelper.GetComboColores()
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddPet(EquipoViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var path = string.Empty;

        //        _context.Colores.Add(color);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction($"Details/{model.OwnerId}");
        //    }

        //    return View(model);
        //}

    }
}
