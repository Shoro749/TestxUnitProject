﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestxUnitProject
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }
}
