using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.BookOperations.Commands.Delete
{
    public class DeleteBookCommand:IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }
    }
}