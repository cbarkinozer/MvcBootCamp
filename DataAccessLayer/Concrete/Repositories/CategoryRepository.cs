using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        DbSet<Category> _object;
        Context context = new Context();

        public void Delete(Category category)
        {
            _object.Remove(category);
            context.SaveChanges();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}
