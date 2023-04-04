using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLeyer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categordal;

        public CategoryManager(ICategoryDal categordal)
        {
            _categordal = categordal;
        }

        public void CategoryAdd(Category category)
        {
          _categordal.Insert(category); 
        }

        public void CategoryDelete(Category category)
        {
            _categordal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categordal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categordal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categordal.list();
        }
    }
}
