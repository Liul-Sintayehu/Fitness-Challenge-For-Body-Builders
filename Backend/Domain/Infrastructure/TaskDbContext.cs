using Microsoft.EntityFrameworkCore;
using Task_Management_System.Domain.Models;

namespace Task_Management_System.Domain.Infrastructure
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
            
        }
        public DbSet<ToDoTask> ToDoTasks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
    }
}
