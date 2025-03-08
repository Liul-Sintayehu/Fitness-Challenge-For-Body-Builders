using System.ComponentModel.DataAnnotations;

namespace Task_Management_System.Domain.Models
{
    public class Employee : BaseEntity
    {
        [Required(ErrorMessage = "Employee Id is Mandatory")]
        public int EmpId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public static Employee Create(int empId, string name, string phone, decimal salary)
        {
            Employee emp = new Employee
            {
                EmpId = empId,
                Name = name,
                Phone = phone,
                Salary = salary

            };

            return emp;
        }
        public void Update(int empId, string name, string phone, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Phone = phone;
            Salary = salary;
        }
    }

   
}
