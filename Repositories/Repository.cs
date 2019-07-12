using NHibernate;

namespace Repositories
{
    public class Repository<T>:IRepository<T>
    {
        protected ISession _session;
        public Repository(ISession session)
        {
            _session = session;
        }

        public void Delete(T entity)
        {
            _session.Delete(entity);
        }

        public T GetById(int id)
        {
            return _session.Get<T>(id);
        }

        public void Save(T entity)
        {
            _session.Save(entity);
        }
        
    }

}
