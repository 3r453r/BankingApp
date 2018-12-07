using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Elements { get; }

        void Add(T t);

        void Remove(T t);        
    }
}
