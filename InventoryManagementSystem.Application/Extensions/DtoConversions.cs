using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Application.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categories)
        {
            return (from category in categories
            select new CategoryDto
            {
                Id = category.Id,
                FirstName = category.FirstName,
                LastName = category.LastName,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                ModifiedAt = category.ModifiedAt
            }).ToList();
        }

        public static CategoryDto ConvertToDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                FirstName = category.FirstName,
                LastName = category.LastName,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                ModifiedAt = category.ModifiedAt
            };
        }

        public static Category ConvertToEntity(this CategoryDto categoryDto)
        {
            return new Category
            {
                Id = categoryDto.Id,
                FirstName = categoryDto.FirstName,
                LastName = categoryDto.LastName,
                Description = categoryDto.Description,
                CreatedAt = categoryDto.CreatedAt,
                ModifiedAt = categoryDto.ModifiedAt
            };
        }
    }
}
