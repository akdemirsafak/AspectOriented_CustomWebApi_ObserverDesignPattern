using MediatR;

using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.CustomerOperations.Commands.Create
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, ResponseDto<int>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMediator _mediator;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mediator = mediator;
        }


        public async Task<ResponseDto<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            int id=await _customerRepository.Save(request);
            return ResponseDto<int>.Success(id,201);
        }
    }
}