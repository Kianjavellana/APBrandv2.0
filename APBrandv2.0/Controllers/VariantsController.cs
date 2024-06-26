using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APBrandv2._0.Data;
using APBrandv2._0.Models;

namespace APBrandv2._0.Controllers
{
    public class VariantsController : Controller
    {
        private readonly AppDBContext _context;

        public VariantsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Variants
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.Variants.Include(v => v.Model);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Variants/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Variants == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants
                .Include(v => v.Model)
                .FirstOrDefaultAsync(m => m.VariantId == id);
            if (variant == null)
            {
                return NotFound();
            }

            return View(variant);
        }

        // GET: Variants/Create
        public IActionResult Create()
        {
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelName");
            return View();
        }

        // POST: Variants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VariantId,ModelID,VariantName,MainCamera,SelfieCamera,BodyRatio,Network,Display,Platform,COMMS,Memory,Features,Battery,MISC,Tests")] Variant variant)
        {
            if (ModelState.IsValid)
            {
                variant.VariantId = Guid.NewGuid();
                _context.Add(variant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelName", variant.ModelID);
            return View(variant);
        }

        // GET: Variants/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Variants == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants.FindAsync(id);
            if (variant == null)
            {
                return NotFound();
            }
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelName", variant.ModelID);
            return View(variant);
        }

        // POST: Variants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("VariantId,ModelID,VariantName,MainCamera,SelfieCamera,BodyRatio,Network,Display,Platform,COMMS,Memory,Features,Battery,MISC,Tests")] Variant variant)
        {
            if (id != variant.VariantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(variant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VariantExists(variant.VariantId))
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
            ViewData["ModelID"] = new SelectList(_context.Models, "ModelID", "ModelName", variant.ModelID);
            return View(variant);
        }

        // GET: Variants/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Variants == null)
            {
                return NotFound();
            }

            var variant = await _context.Variants
                .Include(v => v.Model)
                .FirstOrDefaultAsync(m => m.VariantId == id);
            if (variant == null)
            {
                return NotFound();
            }

            return View(variant);
        }

        // POST: Variants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Variants == null)
            {
                return Problem("Entity set 'AppDBContext.Variants'  is null.");
            }
            var variant = await _context.Variants.FindAsync(id);
            if (variant != null)
            {
                _context.Variants.Remove(variant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VariantExists(Guid id)
        {
          return (_context.Variants?.Any(e => e.VariantId == id)).GetValueOrDefault();
        }
    }
}
