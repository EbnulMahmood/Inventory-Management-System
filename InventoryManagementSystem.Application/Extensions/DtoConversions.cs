using InventoryManagementSystem.Application.Dtos;
using InventoryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        Name = category.Name,
                        Description = category.Description,
                        CreatedAt = category.CreatedAt,
                        ModifiedAt = category.ModifiedAt
                    }).ToList();
        }

        public static CategoryDto ConvertToDto(this Category category)
        {
            return (new CategoryDto
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Description = category.Description,
                        CreatedAt = category.CreatedAt,
                        ModifiedAt = category.ModifiedAt
                    });
        }
    }
}
