using DataAccess.Models.Entities;
namespace BusinessLogic.Services
{
    public interface IBaseService<T>where T: BaseProduct
    {
        List<T> GetAll();
        void Create(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
    }
}
