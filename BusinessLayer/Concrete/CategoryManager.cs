using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repository.List();
        }
        public void CategoryAddBL(Category category)
        {
            if (category.CategoryName == "" || category.CategoryName.Length <= 3
                || category.CategoryDescription == "" || category.CategoryName.Length >= 51)
            {
                //Error message
            }
            else
            {
                repository.Insert(category);
            }
        }
    }
}
