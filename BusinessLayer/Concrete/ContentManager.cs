﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLeyer.Abstract;
using DataAccessLeyer.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;
        private EfContentDal efContentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

       

        public List<Content> GetListByHeadingId(int id)
        {
          return   _contentDal.list(x => x.HeadingID == id);
        }
    }
}
