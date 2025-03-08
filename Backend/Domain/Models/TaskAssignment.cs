namespace Task_Management_System.Domain.Models
{
    public class TaskAssignment : BaseEntity
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public ToDoTask Task { get; set; }
        public long TaskId { get; set; }
        public bool Status { get; set; } 
        public static TaskAssignment Create(long taskId)
        {
            var taskAssignment = new TaskAssignment()
            {
                TaskId = taskId,
            };
            return taskAssignment;
        }
    }
}
