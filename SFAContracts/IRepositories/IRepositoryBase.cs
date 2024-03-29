﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SFAContracts.IRepositories
{
   public interface IRepositoryBase<T> where T: class
    {
        Task<T> FindAsync(int id);
        Task<IEnumerable<T>> FindAllAsync();
       
        Task Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
    }
}
