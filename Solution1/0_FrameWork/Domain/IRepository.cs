using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _0_FrameWork.Domain
{
 public   interface IRepository <Tkey,T> where T:class
 {
     T Get(Tkey id);
     List<T> Get();
     bool Exists(Expression<Func<T, bool>> expression);
     void Create(T entity);
     void SaveChanges();
 }
}
