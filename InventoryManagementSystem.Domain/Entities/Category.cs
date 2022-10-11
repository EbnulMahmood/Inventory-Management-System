using InventoryManagementSystem.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Entities
{
    public class Category : BaseEntity<Guid>, IEntity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
