using MediatR;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Commands
{
    public record CreateEmployee(int empId, string Name, string phone, decimal salary) : IRequest<OperationResult<Employee>>;
    internal class CreateEmployeeHandler(IRepositoryBase<Employee> employeeRepository) : IRequestHandler<CreateEmployee, OperationResult<Employee>>
    {
        public async Task<OperationResult<Employee>> Handle(CreateEmployee request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Employee>();
            var employee = await employeeRepository.FirstOrDefaultAsync(emp => emp.EmpId == request.empId);
            if (employee != null)
            {
                result.AddError(ErrorCode.RecordAlreadyExists, "Record already exists");
                return result;
            }

            var emp = Employee.Create(request.empId,request.Name,request.phone,request.salary);
 
                await employeeRepository.AddAsync(emp);
                result.Payload = emp;
                result.Message = "Succsesfully created an employee";
            
            return result;
        }
    }
}
