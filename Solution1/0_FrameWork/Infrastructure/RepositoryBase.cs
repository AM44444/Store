using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using _0_FrameWork.Domain;
using Microsoft.EntityFrameworkCore;

namespace _0_FrameWork.Infrastructure
{
  public  class RepositoryBase<Tkey,T> : IRepository<Tkey,T> where T: class
  {
      private readonly DbContext _context;

      public RepositoryBase(DbContext context)
      {
          _context = context;
      }
      public T Get(Tkey id)
      {
          return _context.Find<T>(id);
      }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public void Create(T entity)
        {
             _context.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
