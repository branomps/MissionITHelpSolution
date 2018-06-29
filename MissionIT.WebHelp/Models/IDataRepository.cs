using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelp.Models
{
    internal interface IRepository<T> where T : class
    {
        T GetOne(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(string s);
        void Add(T tEntity);
        void Update(T tEntiy);
        void Remove(int id);

    }
}
