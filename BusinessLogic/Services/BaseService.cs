using DataAccess.Models.Context;
using DataAccess.Models.Entities;

namespace BusinessLogic.Services
{
    public class BaseService<T>:IBaseService<T> where T : BaseProduct
    {
        MerisPattiserieContext merisPattiserieContext= new MerisPattiserieContext();

        public void Create(T entity)
        {
            merisPattiserieContext.Set<T>().Add(entity);
            merisPattiserieContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            merisPattiserieContext.Set<T>().Remove(entity);
            merisPattiserieContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return merisPattiserieContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return merisPattiserieContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            var updated = merisPattiserieContext.Set<T>().Find(entity.ID);
            merisPattiserieContext.Entry(updated).CurrentValues.SetValues(entity);
            merisPattiserieContext.SaveChanges();
        }
    }
}
