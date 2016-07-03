using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;
using System.Web.Mvc;

namespace WebDeveloper.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersData _customers = new CustomersData();
        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers.GetList());
        }

        public ActionResult Create()
        {
            return View(new Customers());
        }
        [HttpPost]
        public ActionResult Create(Customers customers)
        {
            if (ModelState.IsValid)
            {
                _customers.Add(customers);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            var customers = _customers.GetCustomersByID(id);
            if (customers == null)
            {
                return RedirectToAction("Index");
            }
            return View(customers);
        }
        [HttpPost]
        public ActionResult Delete(Customers customers)
        {
            if (_customers.Delete(customers) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(customers);
        }

        public ActionResult Edit(string id)
        {
            var customers = _customers.GetCustomersByID(id);
            if (customers == null)
            {
                return HttpNotFound();
            }
            return View(customers);
        }
        [HttpPost]
        public ActionResult Edit(Customers customers)
        {
            if (ModelState.IsValid)
            {
                _customers.Update(customers);
                return RedirectToAction("Index");
            }
            return View(customers);
        }
    }
}