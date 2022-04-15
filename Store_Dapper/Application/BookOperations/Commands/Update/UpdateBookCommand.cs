using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.BookOperations.Commands.Update
{
    public class UpdateBookCommand:IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        
        
        
    }
}