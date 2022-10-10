using InventoryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.IDaos
{
    public interface ICategoryDao : IBaseDao<Category>
    {
        Task<IEnumerable<Category>> LoadEntitiesAsync();
    } 
}
