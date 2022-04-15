using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.CustomerOperations.Queries.GetAll
{
    public class CustomerGetAllQuery:IRequest<ResponseDto<List<CustomerDto>>>
    {
        

    }
}