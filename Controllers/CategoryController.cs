using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpanseTrackerspro.Models;

namespace ExpanseTrackerspro.Controllers
{
    public class CategoryController : Controller
    {
        CategoryDataAcessLayer objcategory = new();
        public IActionResult Index()
        {
            List<Category> lstEmployee = new List<Category>();
            lstEmployee = objcategory.GetAllCategory().ToList();

            return View(lstEmployee);
        }
        public ActionResult AddEditCategory(int itemId)
        {
            Models.Category model = new Models.Category();
            if (itemId > 0)
            {
                model = objcategory.GetCategoryData(itemId);
            }
            return PartialView("_expenseForm", model);
        }
        [HttpPost]
        public ActionResult Create(Models.Category newExpense)
        {
            if (ModelState.IsValid)
            {
                if (newExpense.CatId > 0)
                {
                    objcategory.UpdateCategory(newExpense);
                }
                else
                {
                    objcategory.AddCategory(newExpense);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            objcategory.DeleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}
