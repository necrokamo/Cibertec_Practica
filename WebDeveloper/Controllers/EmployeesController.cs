using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeesData _employees = new EmployeesData();
        // GET: Employees
        public ActionResult Index()
        {
            return View(_employees.GetList());
        }

        public ActionResult Create()
        {
            return View(new Employees());
        }
        [HttpPost]
        public ActionResult Create(Employees employees)
        {
            if (ModelState.IsValid)
            {
                _employees.Add(employees);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var employees = _employees.GetEmployeesByID(id);
            if (employees == null)
            {
                return RedirectToAction("Index");
            }
            return View(employees);
        }
        [HttpPost]
        public ActionResult Delete(Employees employees)
        {
            if (_employees.Delete(employees) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(employees);
        }

        public ActionResult Edit(int id)
        {
            var employees = _employees.GetEmployeesByID(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }
        [HttpPost]
        public ActionResult Edit(Employees employees)
        {
            if (ModelState.IsValid)
            {
                _employees.Update(employees);
                return RedirectToAction("Index");
            }
            return View(employees);
        }
    }
}