using MediatR;
using Task_Management_System.Common;
using Task_Management_System.Domain.Models;
using Task_Management_System.Domain.Repository.GenericRepository;

namespace Task_Management_System.Application.Commands
{
    public record CreateTask() : IRequest<OperationResult<ToDoTask>>;
    internal class CreateTaskHandler(IRepositoryBase<ToDoTask> taskRepository) : IRequestHandler<CreateTask, OperationResult<ToDoTask>>
    {
        public async Task<OperationResult<ToDoTask>> Handle(CreateTask request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<ToDoTask>();

            var newTask = new ToDoTask { 
             Name = "test 2",
             Description = "description for test 2"
            };
            await taskRepository.AddAsync(newTask);

            result.Payload = newTask;
            result.Message = "Successfull";
            return result;
        }
    }
}
