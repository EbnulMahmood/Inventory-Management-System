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
            Map(x => x.Description);
            Map(x => x.CreatedAt);
            Map(x => x.ModifiedAt);
        }
    }
}
