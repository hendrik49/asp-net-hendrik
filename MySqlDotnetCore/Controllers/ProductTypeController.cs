using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlDotnetCore.Data;
using MySqlDotnetCore.Models;

namespace MySqlDotnetCore.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataContext db = new DataContext();

        public ProductTypeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]

        public IActionResult Index()
        {
            var productTypes = db.ProductTypes.ToList();

            return View(productTypes);
        }

        [HttpGet]

        public IActionResult Create()
        {
            var productCategories = db.ProductCategories.Where(o => o.Status == "Active").ToList();
            ViewBag.productCategories = productCategories;
            return View();
        }

        [HttpPost]

        public IActionResult Create(ProductType item)
        {

            if (ModelState.IsValid)
            {
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]

        public IActionResult Edit(int? id)
        {

            var item = db.ProductTypes.SingleOrDefault(p => p.seq_Id.Equals(id));

            return View(item);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductType item)
        {

            if (ModelState.IsValid)
            {

                ProductType product = db.ProductTypes.SingleOrDefault(p => p.seq_Id.Equals(item.seq_Id));
                if(product != null){
                    db.Update(product);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var item = db.ProductTypes.Find(id);
                db.ProductTypes.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
