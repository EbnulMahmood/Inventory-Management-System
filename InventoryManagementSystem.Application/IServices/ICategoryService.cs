using InventoryManagementSystem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>?> LoadEntitiesAsync(); 
        Task<CategoryDto?> GetEntityByIdAsync(Guid id);
        Task<bool> CreateEntityAsync(CategoryDto entityDto);
        Task<bool> UpdateEntityAsync(CategoryDto entityDto);
    }
}
