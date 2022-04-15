using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.CustomerOperations.Commands.Delete
{
    
    public class DeleteCustomerCommandHandler:IRequestHandler<DeleteCustomerCommand, ResponseDto<NoContent>>
    {
        
         private readonly ICustomerRepository _customerRepository;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ResponseDto<NoContent>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {

            var result = await _customerRepository.Delete(request);

            if (!result)
            {

                return ResponseDto<NoContent>.Fail("silme işlemi başarısız", 500);


            }

            return ResponseDto<NoContent>.Success(204);

        }

    }
}