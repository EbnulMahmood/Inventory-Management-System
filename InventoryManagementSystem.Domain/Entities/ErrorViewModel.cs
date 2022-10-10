namespace InventoryManagementSystem.Domain.Entities
{
    public class ErrorViewModel
    {
        public virtual string? RequestId { get; set; }

        public virtual bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}