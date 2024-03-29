﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLeyer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
           _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
           _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> list()
        {
            return _object.ToList();    
        }

        public List<Category> list(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
