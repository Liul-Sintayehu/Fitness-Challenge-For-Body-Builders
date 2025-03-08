using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management_System.Application.Commands;
using Task_Management_System.Application.Queries;
using Task_Management_System.Domain.Infrastructure;
using Task_Management_System.Domain.Models;

namespace Task_Management_System.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
 
        private IMediator _mediatorInstance;
        protected IMediator _mediator => _mediatorInstance ??= HttpContext.RequestServices.GetService<IMediator>();


        #region Command
        [HttpPost]
        public async Task<IActionResult> Create( int empId, string name, string phone, decimal salary)
        {
            var result = await _mediator.Send(new CreateEmployee(empId, name, phone, salary));
            return Ok(result.Payload);
        }
        #endregion
        #region Query
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllEmployee());
            return Ok(result);
        }
        #endregion
    }
}
