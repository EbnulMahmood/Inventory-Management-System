using InventoryManagementSystem.Application.Dtos.Contracts;

namespace InventoryManagementSystem.Application.Dtos
{
    public abstract class BaseDto<T> : IDto
    {
        public T Id { get; set; }

        object IDto.Id
        {
            get { return Id; }
            set { }
        }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; }
    }
}
