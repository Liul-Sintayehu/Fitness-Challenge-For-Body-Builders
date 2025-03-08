using MediatR;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Commands
{
    public record CreateTaskAssignment(long taskId, List<long> empId) : IRequest<OperationResult<TaskAssignment>>;
    internal class CreateTaskAssignmentHandler(IRepositoryBase<TaskAssignment> assignmentRepository,IRepositoryBase<Employee> employeeRepository) : IRequestHandler<CreateTaskAssignment, OperationResult<TaskAssignment>>
    {
        public async Task<OperationResult<TaskAssignment>> Handle(CreateTaskAssignment request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<TaskAssignment>();
            var assignment = await assignmentRepository.Where(x => x.TaskId == request.taskId).ToListAsync();
            if (assignment == null)
            {
                result.AddError(ErrorCode.RecordAlreadyExists, "Record already exists");
                return result;
            }
            var taskAssignment = TaskAssignment.Create(request.taskId);
            var employees = await employeeRepository.Where(emp => request.empId.Contains(emp.Id)).ToListAsync();
            if (employees == null)
            {
                result.AddError(ErrorCode.NotFound, "employees not found");
                return result;
            }
            foreach (var employee in employees)
            {
                taskAssignment.Employees.Add(employee);
            }
            await assignmentRepository.AddAsync(taskAssignment);
            result.Payload = taskAssignment;
            return result;

         }
    }
}
