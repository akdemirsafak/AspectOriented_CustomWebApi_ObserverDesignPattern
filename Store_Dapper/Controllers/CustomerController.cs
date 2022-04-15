using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store_Dapper.Application.CustomerOperations.Commands.Create;
using Store_Dapper.Application.CustomerOperations.Commands.Delete;
using Store_Dapper.Application.CustomerOperations.Commands.Update;
using Store_Dapper.Application.CustomerOperations.Queries.GetAll;

namespace Store_Dapper.Controllers
{

    public class CustomerController:ControllerCustomBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
             var response = await _mediator.Send(new CustomerGetAllQuery());

            return CreateActionResult(response);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerCommand createCustomerCommand){
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCustomerCommand updateCustomerCommmand)
        {
            return CreateActionResult(await _mediator.Send(updateCustomerCommmand));
        }
        
         [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id){
            
            return CreateActionResult(await _mediator.Send(new DeleteCustomerCommand(){Id=id}));
        }
    }
}