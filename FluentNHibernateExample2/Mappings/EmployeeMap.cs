using Domain.Entities;
using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    public class EmployeeMap:ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Salary);
            References(x => x.Store)
                .Column("Store_id");
        }
    }
}
