using MediatR;
using Store_Dapper.DTOs;

namespace Store_Dapper.Application.CustomerOperations.Commands.Delete
{
    public class DeleteCustomerCommand: IRequest<ResponseDto<NoContent>>
    {
        public int Id { get; set; }
    }
}