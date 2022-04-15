using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.CustomerOperations.Commands.Create
{
    public class CreateCustomerCommand:IRequest<ResponseDto<int>>
    {
        public CustomerDto newCustomer { get; set; }
        
    }
}