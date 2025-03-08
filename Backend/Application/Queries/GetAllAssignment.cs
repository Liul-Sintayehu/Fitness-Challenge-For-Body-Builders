using MediatR;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Queries
{
    public record GetAllAssignment() : IRequest<OperationResult<List<TaskAssignment>>>;
    internal class GetAllAssignmentHandler(IRepositoryBase<TaskAssignment> assignmentRepository) : IRequestHandler<GetAllAssignment, OperationResult<List<TaskAssignment>>>
    {
        public async Task<OperationResult<List<TaskAssignment>>> Handle(GetAllAssignment request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<TaskAssignment>>();
            var assignments = await assignmentRepository.Query().Include(x => x.Employees).Include(x => x.Task).ToListAsync(cancellationToken);
            result.Payload = assignments;
            return result;
         }
    }
}
