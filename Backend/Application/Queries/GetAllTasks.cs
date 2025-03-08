using MediatR;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Queries
{
    public record GetAllTasks() : IRequest<OperationResult<List<ToDoTask>>>;
    internal class GetAllTasksHandler(IRepositoryBase<ToDoTask> tasksRepository) : IRequestHandler<GetAllTasks, OperationResult<List<ToDoTask>>>
{
        public async Task<OperationResult<List<ToDoTask>>> Handle(GetAllTasks request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<List<ToDoTask>>();
            var tasks = await tasksRepository.Query().ToListAsync(cancellationToken);
            
            result.Payload = tasks;
            return result;
        }
    }
}
