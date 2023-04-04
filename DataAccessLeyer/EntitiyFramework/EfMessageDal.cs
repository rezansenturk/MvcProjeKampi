using DataAccessLayer.Abstract;
using DataAccessLeyer.Abstract;
using DataAccessLeyer.Concrete.Repositories;

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLeyer.EntitiyFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
    }
}
