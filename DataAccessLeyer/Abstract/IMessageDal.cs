﻿
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLeyer.Abstract
{
    public interface IMessageDal : IRepository<Message>
    {
    }
}