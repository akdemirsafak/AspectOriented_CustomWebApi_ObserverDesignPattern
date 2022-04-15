using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.BookOperations.Queries.GetAll
{
    public class BookGetAllQuery:IRequest<ResponseDto<List<BookDto>>>
    {
        
    }
}