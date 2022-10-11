using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Domain.Entities;

namespace InventoryManagementSystem.Application.Extensions
{
    public static class DtoConversions
    {
        private static CategoryDto NewCategoryDto(Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                CreatedAt = category.CreatedAt,
                ModifiedAt = category.ModifiedAt
            };
        }

        private static Category NewCategory(CategoryDto categoryDto)
        {
            return new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Description = categoryDto.Description,
                CreatedAt = categoryDto.CreatedAt,
                ModifiedAt = categoryDto.ModifiedAt
            };
        }

        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categories)
        {
            return (from category in categories
            select NewCategoryDto(category)).ToList();
        }

        public static CategoryDto ConvertToDto(this Category category)
        {
            return NewCategoryDto(category);
        }

        public static Category ConvertToCategory(this CategoryDto categoryDto)
        {
            return NewCategory(categoryDto);
        }
    }
}
