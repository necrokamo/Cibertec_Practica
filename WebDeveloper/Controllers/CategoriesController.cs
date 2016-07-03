using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;
using System.Web.Mvc;

namespace WebDeveloper.Controllers
{
    public class CategoriesController : Controller
    {
        private CategoriesData _category = new CategoriesData();
        // GET: Categories
        public ActionResult Index()
        {
            return View(_category.GetList());
        }

        public ActionResult Create()
        {
            return View(new Categories());
        }
        [HttpPost]
        public ActionResult Create(Categories categories)
        {
            if (ModelState.IsValid)
            {
                _category.Add(categories);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var categories = _category.GetCategoryByID(id);
            if (categories == null)
            {
                return RedirectToAction("Index");
            }
            return View(categories);
        }
        [HttpPost]
        public ActionResult Delete(Categories categories)
        {
            if (_category.Delete(categories) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(categories);
        }

        public ActionResult Edit(int id)
        {
            var categories = _category.GetCategoryByID(id);
            if (categories == null)
            {
                return HttpNotFound();
            }
            return View(categories);
        }
        [HttpPost]
        public ActionResult Edit(Categories categories)
        {
            if (ModelState.IsValid)
            {
                _category.Update(categories);
                return RedirectToAction("Index");
            }
            return View(categories);
        }
    }
}