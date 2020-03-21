using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using H_EstateAgency2.Models;
using Microsoft.AspNetCore.Authorization;

namespace H_EstateAgency2.Controllers
{
    [Authorize(Roles = "Staff, Admin")]
    public class PropertiesController : Controller
    {
        private readonly AppDBContext _context;

        public PropertiesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Properties.ToListAsync());
        }

        // GET: Properties/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties



                // these following two lines make the pictures available for model property
                .Include(m => m.pictures)
                .AsNoTracking()
                // the two line ended





                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            //fetch list of the cities
            List<PCity> li = new List<PCity>();
            li = _context.PCitys.ToList();
            //default label
            li.Insert(0, new PCity { PCityId = 0, PCityName = "--Select City--", PCityNo = 0 });
            ViewBag.listofcities = li;


            //fetch list of property types
            List<PType> lit = new List<PType>();
            lit = _context.PTypes.ToList();
            //default label
            lit.Insert(0, new PType { PTypeId = 0, PTypeName = "--Select Type--", PTypeNo = 0 });
            ViewBag.listoftypes = lit;


            //fetch list of post purpose
            List<Purpose> lip = new List<Purpose>();
            lip = _context.Purpose.ToList();
            //default label
            lip.Insert(0, new Purpose { purposeID = 0, purposefor = "--Select Purpose --" });
            ViewBag.listofpurposes = lip;
            return View();
        }


        public IActionResult Create3()
        {
            List<PCity> li = new List<PCity>();
            li = _context.PCitys.ToList();
            //default label
            li.Insert(0, new PCity { PCityId = 0, PCityName = "--Select City--", PCityNo = 0 });
            ViewBag.listofcities = li;
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyId,PropertyType,PropertyTitle,PropertyCity,PropertyAddress,PropertyArea,PropertyPrice,PropertyYearOfBuilt,PropertyComBuilt,isAvailable, Description, Ppurpose")] Property @property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@property);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyId,PropertyType,PropertyTitle,PropertyCity,PropertyAddress,PropertyArea,PropertyPrice,PropertyYearOfBuilt,PropertyComBuilt,isAvailable,Description, Ppurpose")] Property @property)
        {
            if (id != @property.PropertyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyId))
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
            return View(@property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Properties
                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
         
            var @property = await _context.Properties.FindAsync(id);
            _context.Properties.Remove(@property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyId == id);
        }


    }
}
