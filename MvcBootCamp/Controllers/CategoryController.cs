using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootCamp.Controllers
{
    
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList() 
        {
            var categoryValues = categoryManager.GetAllBL();
            return View(categoryValues);
        }
        public ActionResult AddCategory(Category category) 
        {
            categoryManager.CategoryAddBL(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}