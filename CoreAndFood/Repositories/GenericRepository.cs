using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T:class,new()
    {
        Context c = new Context();
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public void TAdd(T ct)
        {
            c.Set<T>().Add(ct);
            c.SaveChanges();
        }
        public void TDelete(T ct)
        {
            c.Set<T>().Remove(ct);
            c.SaveChanges();
        }
        public void TUpdate(T ct)
        {
            c.Set<T>().Update(ct);
            c.SaveChanges();
        }
        public T TGet(int id)
        {
            return c.Set<T>().Find(id);

        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
    }
}
