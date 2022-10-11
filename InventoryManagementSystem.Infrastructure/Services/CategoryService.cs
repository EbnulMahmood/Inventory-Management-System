using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Application.Extensions;
using InventoryManagementSystem.Application.IDaos;
using InventoryManagementSystem.Application.IServices;
using InventoryManagementSystem.Infrastructure.Extensions;

namespace InventoryManagementSystem.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDao _categoryDao;

        public CategoryService(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }

        public IDictionary<string, string> ValidateCategoryDto(CategoryDto entityDto)
        {
            Guard.AgainstNullParameter(entityDto, "entityDto");

            Dictionary<string, string> errors = new();

            if (entityDto.Name.Trim().Length == 0)
                errors.Add("Name", "Name is required.");
            if (entityDto.Description.Trim().Length == 0)
                errors.Add("Description", "Description is required.");
            return errors;
        }

        public async Task<IEnumerable<CategoryDto>?> ListEntitiesAsync()
        {
            try
            {
                var entities = await _categoryDao.ListEntitiesAsync();
                if (entities == null) return null;

                var entitiesDto = entities.ConvertToDto();

                return entitiesDto;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public async Task<CategoryDto?> GetEntityByIdAsync(Guid id)
        {
            try
            {
                var entity = await _categoryDao.GetEntityByIdAsync(id);
                if (entity == null) return null;

                var entityDto = entity.ConvertToDto();
                return entityDto;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public async Task<bool> CreateEntityAsync(CategoryDto entityDto)
        {
            try
            {
                var entity = entityDto.ConvertToCategory();
                if (!await _categoryDao.CreateEntityAsync(entity)) return false;
                return true;
            }
            catch (Exception)
            {

                throw;
            };
        }

        public async Task<bool> UpdateEntityAsync(CategoryDto entityDto)
        {
            try
            {
                var entity = entityDto.ConvertToCategory();
                if (!await _categoryDao.UpdateEntityAsync(entity)) return false;
                return true;
            }
            catch (Exception)
            {

                throw;
            };
        }
    }
}
