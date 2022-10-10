using InventoryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.IRepositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> LoadCategoriesAsync();
        Task<Category?> GetCategoryByIdAsync(Guid id);
    }
}
