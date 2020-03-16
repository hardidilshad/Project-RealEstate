using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using H_EstateAgency2.Models;

namespace H_EstateAgency2.Controllers
{
    public class PTypesController : Controller
    {
        private readonly AppDBContext _context;

        public PTypesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: PTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PTypes.ToListAsync());
        }

        // GET: PTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pType = await _context.PTypes
                .FirstOrDefaultAsync(m => m.PTypeId == id);
            if (pType == null)
            {
                return NotFound();
            }

            return View(pType);
        }

        // GET: PTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PTypeId,PTypeName,PTypeNo")] PType pType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pType);
        }

        // GET: PTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pType = await _context.PTypes.FindAsync(id);
            if (pType == null)
            {
                return NotFound();
            }
            return View(pType);
        }

        // POST: PTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PTypeId,PTypeName,PTypeNo")] PType pType)
        {
            if (id != pType.PTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PTypeExists(pType.PTypeId))
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
            return View(pType);
        }

        // GET: PTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pType = await _context.PTypes
                .FirstOrDefaultAsync(m => m.PTypeId == id);
            if (pType == null)
            {
                return NotFound();
            }

            return View(pType);
        }

        // POST: PTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pType = await _context.PTypes.FindAsync(id);
            _context.PTypes.Remove(pType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PTypeExists(int id)
        {
            return _context.PTypes.Any(e => e.PTypeId == id);
        }
    }
}
