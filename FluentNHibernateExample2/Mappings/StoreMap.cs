using FluentNHibernate.Mapping;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mappings
{
    public class StoreMap:ClassMap<Store>
    {
        public StoreMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Employees)
                .Inverse()
                .Cascade.All();
            HasManyToMany(x => x.Products)
                .Cascade.All()
                .Table("StoreProduct");   
        }
    }
}
