using Task_Management_System.Common;

namespace Task_Management_System.Domain.Models
{
    public class ToDoTask : BaseEntity
    {
        public required string Name { get; set; } 
        public string Description { get; set; } = string.Empty;
    }
}
