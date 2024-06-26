using APBrandv2._0.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APBrandv2._0.Controllers
{
    public class AppleViewController : Controller
    {
        public IActionResult Index()
        {
            string sharedData = ViewBag.SharedData;
            // Use sharedData in Controller2

            return View();
        }
        public  AppDBContext _context;
       
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
    }
}
