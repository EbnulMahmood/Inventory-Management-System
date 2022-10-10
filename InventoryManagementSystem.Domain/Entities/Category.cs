using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Entities
{
    public class Category
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Created_At { get; set; } = DateTime.Now;
        public virtual DateTime Modified_At { get; set; } = DateTime.Now;
    }
}
