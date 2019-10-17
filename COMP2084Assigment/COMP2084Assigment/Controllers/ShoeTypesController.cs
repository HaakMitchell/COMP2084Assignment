using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP2084Assigment.Data;
using COMP2084Assigment.Models;

namespace COMP2084Assigment.Controllers
{
    public class ShoeTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoeTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoeTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShoeType.ToListAsync());
        }

        // GET: ShoeTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoeType = await _context.ShoeType
                .FirstOrDefaultAsync(m => m.TypeId == id);
            if (shoeType == null)
            {
                return NotFound();
            }

            return View(shoeType);
        }

        // GET: ShoeTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShoeTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeId,BrandId,Name,ReleaseDate")] ShoeType shoeType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoeType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoeType);
        }

        // GET: ShoeTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoeType = await _context.ShoeType.FindAsync(id);
            if (shoeType == null)
            {
                return NotFound();
            }
            return View(shoeType);
        }

        // POST: ShoeTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeId,BrandId,Name,ReleaseDate")] ShoeType shoeType)
        {
            if (id != shoeType.TypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoeType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoeTypeExists(shoeType.TypeId))
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
            return View(shoeType);
        }

        // GET: ShoeTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoeType = await _context.ShoeType
                .FirstOrDefaultAsync(m => m.TypeId == id);
            if (shoeType == null)
            {
                return NotFound();
            }

            return View(shoeType);
        }

        // POST: ShoeTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoeType = await _context.ShoeType.FindAsync(id);
            _context.ShoeType.Remove(shoeType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoeTypeExists(int id)
        {
            return _context.ShoeType.Any(e => e.TypeId == id);
        }
    }
}
