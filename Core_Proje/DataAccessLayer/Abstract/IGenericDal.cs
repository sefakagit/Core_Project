﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t); //T class ismi yerine generictir, t ise referans yerine generic
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
