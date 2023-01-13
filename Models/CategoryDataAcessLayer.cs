using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExpanseTrackerspro.Models
{
    public class CategoryDataAcessLayer
    {
        readonly CategoryDbContext db = new CategoryDbContext();
        public IEnumerable<Category> GetAllCategory()
        {
            try
            {
                return db.Category.ToList();
            }
            catch
            {
                throw;
            }

        }
        //To Add new Expense record       
        public void AddCategory(Category category)
        {
            try
            {
                db.Category.Add(category);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar expense  
        public int UpdateCategory(Category category)
        {
            try
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the data for a particular expense  
        public Category GetCategoryData(int id)
        {
            try
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                Category category = db.Category.Find(id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                return category;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular expense  
        public IActionResult Delete(int id)
        {
            ExpenseDBContext db = new ExpenseDBContext();
            var data = db.ExpenseReport.Where(x => x.ItemId == id).FirstOrDefault();
            db.ExpenseReport.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private IActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }

        internal void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
