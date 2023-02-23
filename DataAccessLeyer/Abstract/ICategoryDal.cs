using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        // CRUD 
        // type Name (); Metotları tanımlarken tipi ismi ve parantez aç kapa noktalı virgül

        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);

        // CRUD Operasyonlarının gerçekleşeceği metotlar bu şekildedir 


    }
}
