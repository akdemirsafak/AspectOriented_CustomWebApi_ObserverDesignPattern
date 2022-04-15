using MediatR;
using Store_Dapper.Application.CustomerOperations.Commands.Update;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.GenreOperations.Commands.Update
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, ResponseDto<NoContent>>
    {
        private readonly ICustomerRepository _repository;

        public UpdateCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseDto<NoContent>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
              var result = await _repository.Update(request);

            if (!result)
            {

                return ResponseDto<NoContent>.Fail("update işlemi başarısız", 500);


            }

            return ResponseDto<NoContent>.Success(204);
        }
    }
}