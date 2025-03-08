using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System.Application.Commands;
using Task_Management_System.Application.Queries;

namespace Task_Management_System.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();
        #region Command
        [HttpPost]
        public async Task<IActionResult> Create(long id,List<long> empId)
        {
            var result = await _mediator.Send(new CreateTaskAssignment(id, empId));
            return Ok(result);
           
        }
        #endregion
        #region Query
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllAssignment());
            return Ok(result);
        }
        #endregion
    }
}
