using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Persistence
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Items { get; }

        T Add(T t);

        void Remove(T t);

        void Save(T t);
    }
}
