namespace Task_Management_System.Common
{
    public class BaseEntity
    {
        public long Id {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } 
    }
}
