using MediatR;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Queries
{
    public record GetAllEmployee() : IRequest<OperationResult<List<Employee>>>;
    internal class GetAllEmployeeHandler(IRepositoryBase<Employee> employeeRepository) : IRequestHandler<GetAllEmployee, OperationResult<List<Employee>>>
    {
        public async Task<OperationResult<List<Employee>>> Handle(GetAllEmployee request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<Employee>>();
            var employees = await employeeRepository.Query().ToListAsync(cancellationToken);
            result.Payload = employees;
             result.Message = "Success";
            return result;
        }
    }
}
