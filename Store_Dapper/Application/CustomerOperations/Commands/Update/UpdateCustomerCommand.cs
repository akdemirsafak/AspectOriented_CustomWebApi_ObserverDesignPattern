using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.CustomerOperations.Commands.Update
{
    public class UpdateCustomerCommand:IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? LastName { get; set; }
        public int Balance { get; set; }
    }
}