﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.DataAccess
{
    public interface WDataAccess<T>
    {
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
    }
}
