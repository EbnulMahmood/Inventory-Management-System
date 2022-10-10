using InventoryManagementSystem.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Entities
{
    public abstract class BaseEntity<T> : IEntity
    {
        public virtual T Id { get; set; }

        object IEntity.Id
        {
            get { return Id; }
            set { }
        }
        public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedAt { get; set; }
    }
}
