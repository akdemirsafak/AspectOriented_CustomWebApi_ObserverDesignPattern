using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.CustomerOperations.Queries.GetById
{
    public class CustomerGetByIdQuery:IRequest<ResponseDto<CustomerDto>>
    {
        
    }
}