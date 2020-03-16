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
    public class PCitiesController : Controller
    {
        private readonly AppDBContext _context;

        public PCitiesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: PCities
        public async Task<IActionResult> Index()
        {
            return View(await _context.PCitys.ToListAsync());
        }

        // GET: PCities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCity = await _context.PCitys
                .FirstOrDefaultAsync(m => m.PCityId == id);
            if (pCity == null)
            {
                return NotFound();
            }

            return View(pCity);
        }

        // GET: PCities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PCityId,PCityName,PCityNo")] PCity pCity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pCity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pCity);
        }

        // GET: PCities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCity = await _context.PCitys.FindAsync(id);
            if (pCity == null)
            {
                return NotFound();
            }
            return View(pCity);
        }

        // POST: PCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PCityId,PCityName,PCityNo")] PCity pCity)
        {
            if (id != pCity.PCityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pCity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PCityExists(pCity.PCityId))
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
            return View(pCity);
        }

        // GET: PCities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pCity = await _context.PCitys
                .FirstOrDefaultAsync(m => m.PCityId == id);
            if (pCity == null)
            {
                return NotFound();
            }

            return View(pCity);
        }

        // POST: PCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pCity = await _context.PCitys.FindAsync(id);
            _context.PCitys.Remove(pCity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PCityExists(int id)
        {
            return _context.PCitys.Any(e => e.PCityId == id);
        }
    }
}
