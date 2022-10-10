using FluentNHibernate.Mapping;
using InventoryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Infrastructure.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table("Categories");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Created_At);
            Map(x => x.Modified_At);
        }
    }
}
