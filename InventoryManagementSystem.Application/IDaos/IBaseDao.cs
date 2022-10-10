using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.IDaos
{
    public interface IBaseDao<T> where T : class
    {
        Task<T> GetEntityByIdAsync(Guid id);
        Task<bool> CreateEntityAsync(T entity);
        Task<bool> UpdateEntityAsync(T entity);
    }
}
