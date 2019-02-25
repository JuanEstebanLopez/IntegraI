using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IntegraI.Models;
using Integra_I.Models;

namespace IntegraI.Controllers
{
    public class CelebracionsController : Controller
    {
        private readonly CelebracionContext _context;

        public CelebracionsController(CelebracionContext context)
        {
            _context = context;
        }

        // GET: Celebracions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Celebracion.ToListAsync());
        }

        // GET: Celebracions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celebracion = await _context.Celebracion
                .SingleOrDefaultAsync(m => m.Id == id);
            if (celebracion == null)
            {
                return NotFound();
            }

            return View(celebracion);
        }

        // GET: Celebracions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Celebracions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoEvento,Direccion,Necesidades,Fecha,Asistentes,Detalles,Nombre,Cedula,Celular,Correo")] Celebracion celebracion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(celebracion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(celebracion);
        }

        // GET: Celebracions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celebracion = await _context.Celebracion.SingleOrDefaultAsync(m => m.Id == id);
            if (celebracion == null)
            {
                return NotFound();
            }
            return View(celebracion);
        }

        // POST: Celebracions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoEvento,Direccion,Necesidades,Fecha,Asistentes,Detalles,Nombre,Cedula,Celular,Correo")] Celebracion celebracion)
        {
            if (id != celebracion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(celebracion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CelebracionExists(celebracion.Id))
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
            return View(celebracion);
        }

        // GET: Celebracions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var celebracion = await _context.Celebracion
                .SingleOrDefaultAsync(m => m.Id == id);
            if (celebracion == null)
            {
                return NotFound();
            }

            return View(celebracion);
        }

        // POST: Celebracions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var celebracion = await _context.Celebracion.SingleOrDefaultAsync(m => m.Id == id);
            _context.Celebracion.Remove(celebracion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CelebracionExists(int id)
        {
            return _context.Celebracion.Any(e => e.Id == id);
        }
    }
}
