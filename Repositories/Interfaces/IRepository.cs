namespace Repositories
{
    public interface IRepository<T> 
    {
        T GetById(int Id);
        void Save(T entity);
        void Delete(T product);

    }
}
