﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppFromScratch.Repository
{
    public interface IRepository<T> where T : class {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> Get();
        void Update();
    }
}
