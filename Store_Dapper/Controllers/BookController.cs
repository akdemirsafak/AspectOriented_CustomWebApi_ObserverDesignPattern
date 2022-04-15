using MediatR;
using Microsoft.AspNetCore.Mvc;
using Store_Dapper.Application.BookOperations.Commands.Create;
using Store_Dapper.Application.BookOperations.Commands.Delete;
using Store_Dapper.Application.BookOperations.Commands.Update;
using Store_Dapper.Application.BookOperations.Queries.GetAll;
using Store_Dapper.DTOs;

namespace Store_Dapper.Controllers
{
    
    public class BookController:ControllerCustomBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
       [HttpGet]
        public async Task<IActionResult> GetAll()
        {
             var response = await _mediator.Send(new BookGetAllQuery());
            return CreateActionResult(response);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(CreateBookCommand createBookCommand){
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateBookCommand updateBookCommand)
        {
            return CreateActionResult(await _mediator.Send(updateBookCommand));
        }
        
         [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id){
            
            return CreateActionResult(await _mediator.Send(new DeleteBookCommand(){Id=id}));
        }
    }
}