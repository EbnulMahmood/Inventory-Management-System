using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Application.Extensions;
using InventoryManagementSystem.Application.IDaos;
using InventoryManagementSystem.Application.IServices;
using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDao _categoryDao;

        public CategoryService(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }

        public async Task<IEnumerable<CategoryDto>> LoadEntitiesAsync()
        {
            IEnumerable<Category> entities = await _categoryDao.LoadCategoriesAsync();
            var entitiesDto = entities.ConvertToDto();
            return entitiesDto;
        }

        public async Task<CategoryDto> GetEntityByIdAsync(Guid id)
        {
            var entity = await _categoryDao.GetCategoryByIdAsync(id);
            var entityDto = entity.ConvertToDto();
            return entityDto;
        }
    }
}
