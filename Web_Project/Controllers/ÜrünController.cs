using Microsoft.AspNetCore.Mvc;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class ÜrünController : Controller
    {
        AppDbContext _context;
        public ÜrünController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ürünler = _context.Ürünler.ToList();
            return View(ürünler);
        }
        [HttpGet]
        public IActionResult Ürün_Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ürün_Ekle(Ürün ürün)
        {
            _context.Ürünler.Add(ürün);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Ürün_Sil(int id)
        {
            var ürün = _context.Ürünler.Find(id);
            _context.Ürünler.Remove(ürün);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }

        [HttpGet]
        public IActionResult Ürün_Güncelle(int id)
        {
            var product = _context.Ürünler.Find(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Ürün_Güncelle(Ürün ürün)
        {
            _context.Ürünler.Update(ürün);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
