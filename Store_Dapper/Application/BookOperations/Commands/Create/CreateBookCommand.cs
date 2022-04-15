using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.BookOperations.Commands.Create
{
    public class CreateBookCommand:IRequest<ResponseDto<int>>
    {
         public BookDto newBook { get; set; }
    }
}