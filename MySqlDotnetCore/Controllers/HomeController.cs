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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataContext db = new DataContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]

        public IActionResult Index()
        {
            var employeeList = db.Products.ToList();

            return View(employeeList);
        }

        [HttpGet]

        public IActionResult Create()
        {
            var productCategories = db.ProductCategories.Where(o => o.Status == "Active").ToList();
            ViewBag.productCategories = productCategories;

            var productTypes = db.ProductTypes.Where(o => o.Status == "Active").ToList();
            ViewBag.productTypes = productTypes;

            return View();
        }

        [HttpPost]

        public IActionResult Create(Product item)
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

            var productCategories = db.ProductCategories.Where(o => o.Status == "Active").ToList();
            ViewBag.productCategories = productCategories;

            var productTypes = db.ProductTypes.Where(o => o.Status == "Active").ToList();
            ViewBag.productTypes = productTypes;

            var item = db.Products.SingleOrDefault(p => p.seq_Id.Equals(id));

            return View(item);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product item)
        {

            if (ModelState.IsValid)
            {

                Product product = db.Products.SingleOrDefault(p => p.seq_Id.Equals(item.seq_Id));
                if(product != null){
                    product.Product_Description = item.Product_Description;
                    product.Product_Category_Code =  item.Product_Category_Code;
                    product.Product_Type_Code = item.Product_Type_Code;
                    product.Product_Name = item.Product_Name;
                    product.Status = item.Status;
                    product.Update_Date = DateTime.Now;
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
                var item = db.Products.Find(id);
                db.Products.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
