using InventoryManagementSystem.Application.Dtos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.Dtos
{
    public class CategoryDto : BaseDto<Guid>, IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
