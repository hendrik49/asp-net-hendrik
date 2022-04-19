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
    public class ProductCategoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DataContext db = new DataContext();

        public ProductCategoryController(ILogger<HomeController> logger)
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
            var productCategories = db.ProductCategories.ToList();

            return View(productCategories);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(ProductCategory item)
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

            var item = db.ProductCategories.SingleOrDefault(p => p.seq_Id.Equals(id));

            return View(item);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductCategory item)
        {

            if (ModelState.IsValid)
            {

                ProductCategory productCategory = db.ProductCategories.SingleOrDefault(p => p.seq_Id.Equals(item.seq_Id));
                if(productCategory != null){
                    productCategory.Category_Description = item.Category_Description;
                    productCategory.Product_Category_Code =  item.Product_Category_Code;
                    productCategory.Category_Name = item.Category_Name;
                    productCategory.Status = item.Status;
                    productCategory.Update_Date = DateTime.Now;
                    db.Update(productCategory);
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
                var item = db.ProductCategories.Find(id);
                item.Is_Deleted = true;
                db.Update(item);                
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
