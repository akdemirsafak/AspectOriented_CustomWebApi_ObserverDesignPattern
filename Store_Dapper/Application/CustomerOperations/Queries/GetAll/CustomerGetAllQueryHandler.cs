using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.CustomerOperations.Queries.GetAll
{
    public class CustomerGetAllQueryHandler: IRequestHandler<CustomerGetAllQuery, ResponseDto<List<CustomerDto>>>
    {
        private readonly ICustomerRepository _repository;

        public CustomerGetAllQueryHandler(ICustomerRepository repository)
        {
            _repository =repository;
        }

        public async Task<ResponseDto<List<CustomerDto>>> Handle(CustomerGetAllQuery request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetAll();

            var customersDtos = new List<CustomerDto>();

            customers.ForEach(x => customersDtos.Add(new CustomerDto(x)));

            return ResponseDto<List<CustomerDto>>.Success(customersDtos, 200);
        }
    }
}