using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using H_EstateAgency2.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace H_EstateAgency2.Controllers
{

    [Authorize(Roles = "Staff, Admin")]
    public class PicturesController : Controller
    {
        private readonly AppDBContext _context;

        public PicturesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Pictures
      
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pictures.ToListAsync());
        }
        // GET: Pictures/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures
                .FirstOrDefaultAsync(m => m.PicId == id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture);
        }

        // GET: Pictures/Create
        public IActionResult Create()
        {
            populatePropertyIDs();
            return View();
        }

        // POST: Pictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PicId,photo,PicName,PropertyId")] Picture picture)
        {
            if (ModelState.IsValid)
            {
                picture.PropertyId = 7;
                _context.Add(picture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            populatePropertyIDs();
            return View(picture);
        }






        [HttpPost]
        public async Task<IActionResult> UploadImage(Picture obj)
        {
            
            foreach (var file in Request.Form.Files)
            {
                Picture img = new Picture();
                img.PicName = file.FileName;
             
                MemoryStream ms = new MemoryStream();

                img.PropertyId = obj.PropertyId;
             file.CopyTo(ms);
                img.photo = ms.ToArray();

                ms.Close();
                ms.Dispose();


                _context.Pictures.Add(img);
                _context.SaveChanges();
            }
            ViewBag.Message = "Image(s) stored in database!";
            populatePropertyIDs();


            var result = await _context.Pictures.ToListAsync();

            return View("Index", result);
        }



        // GET: Pictures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            return View(picture);
        }

        // POST: Pictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PicId,photo,PicName,PropertyId")] Picture picture)
        {
            if (id != picture.PicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(picture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PictureExists(picture.PicId))
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
            return View(picture);
        }

        // GET: Pictures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures
                .FirstOrDefaultAsync(m => m.PicId == id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture);
        }

        // POST: Pictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var picture = await _context.Pictures.FindAsync(id);
            _context.Pictures.Remove(picture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PictureExists(int id)
        {
            return _context.Pictures.Any(e => e.PicId == id);
        }

        //this will populate the drop dwon for property id
        public void populatePropertyIDs()
        {
            var propertyQuery = (from d in _context.Properties
                                 orderby d.PublishingDate
                                 select d).ToArray();
           
            ViewBag.PropertyId = new SelectList(propertyQuery, "PropertyId", "PropertyId");

            
            
        }


    }

}
