﻿using DataAccessLayer.Abstract;
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

        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            var list = _object.ToList(); //EntityFramework de verileri listelemek için kullanılan metot dur 
            return list;
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}

/*
 
 Tolist - Listeleme işlemi için 
 Add - Ekleme işlemi için
 Remove - Silme işlemi için
 Find - Bulma işlemi için

 */