using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System.Application.Commands;
using Task_Management_System.Application.Queries;
using Task_Management_System.Domain.Infrastructure;
using Task_Management_System.Domain.Models;

namespace Task_Management_System.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoTaskController : ControllerBase
    {
        
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();
        
        #region Query
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllTasks());
            return Ok(result.Payload);
        }
        #endregion
        #region Command
        [HttpPost("Create")]
        public async Task<IActionResult> Create()
        {
            var result = await _mediator.Send(new CreateTask());
            return Ok(result.Payload);
        }
        #endregion
    }
}
