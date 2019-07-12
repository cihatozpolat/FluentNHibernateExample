using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository<Employee> : IRepository<Employee>
    {
        protected ISession _session;

        public EmployeeRepository(ISession session)
        {
            _session = session;
        }
        public void Delete(Employee employee)
        {
            _session.Delete(employee);
        }

        public Employee GetById(int Id)
        {
            return _session.Get<Employee>(Id);
        }

        public void Save(Employee entity)
        {
            _session.Save(entity);
        }
    }
}
