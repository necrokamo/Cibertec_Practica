using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;
using System.Web.Mvc;

namespace WebDeveloper.Controllers
{
    public class ProductsController : Controller
    {
        private ProductsData _products = new ProductsData();
        // GET: Products
        public ActionResult Index()
        {
            return View(_products.GetList());
        }

        public ActionResult Create()
        {
            return View(new Products());
        }
        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                _products.Add(products);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var products = _products.GetProductsByID(id);
            if (products == null)
            {
                return RedirectToAction("Index");
            }
            return View(products);
        }
        [HttpPost]
        public ActionResult Delete(Products products)
        {
            if (_products.Delete(products) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(products);
        }

        public ActionResult Edit(int id)
        {
            var products = _products.GetProductsByID(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }
        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                _products.Update(products);
                return RedirectToAction("Index");
            }
            return View(products);
        }
    }
}