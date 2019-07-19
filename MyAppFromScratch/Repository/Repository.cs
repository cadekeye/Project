using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace MyAppFromScratch.Repository
{
   public class Repository<T> : IRequiresSessionState, IRepository<T> where T : class
   {
       private readonly List<T> lists = new List<T>();
       private readonly HttpSessionState session = HttpContext.Current.Session;

       public void Add(T entity) {
           lists.Add(entity);
           Update();
       }

       public void Remove(T entity) {
           lists.Remove(entity);
           Update();
       }

       public IEnumerable<T> Get() {
          return lists;
       }

       public void Update() {
           session[nameof(T)] = lists;
       }
   }
}
