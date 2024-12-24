using Microsoft.AspNetCore.Mvc;
using FacebookGoogleAPIProject.Models;
using FacebookGoogleAPIProject.Data;

namespace FacebookGoogleAPIProject.Controllers
{
    public class AdMetricsController : Controller
    {
        private readonly AppDbContext _context;
        public AdMetricsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var adMetrics = _context.AdMetrics.ToList();
            return View(adMetrics);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AdMetric adMetric)
        {
            if (ModelState.IsValid)
            {
                _context.AdMetrics.Add(adMetric);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adMetric);
        }
        public IActionResult Delete(int id)
        {
            var adMetric = _context.AdMetrics.Find(id);
            if (adMetric != null)
            {
                _context.AdMetrics.Remove(adMetric);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}