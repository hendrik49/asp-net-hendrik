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
            var employeeList = db.Employees.ToList();

            return View(employeeList);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employee item)
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

            var item = db.Employees.SingleOrDefault(p => p.id.Equals(id));

            return View(item);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee item)
        {

            if (ModelState.IsValid)
            {

                Employee employee = db.Employees.SingleOrDefault(p => p.id.Equals(item.id));
                employee.employee_id = item.employee_id;
                employee.salary = item.salary;
                employee.birthdate = item.birthdate;
                employee.address = item.address;
                employee.department_id = item.department_id;
                db.Update(employee);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var item = db.Employees.Find(id);
                db.Employees.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
