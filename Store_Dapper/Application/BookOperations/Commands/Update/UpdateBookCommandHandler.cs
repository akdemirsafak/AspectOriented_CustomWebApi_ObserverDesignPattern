using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.BookOperations.Commands.Update
{
     public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, ResponseDto<NoContent>>
    {

        private readonly IBookRepository _repository;

        public UpdateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }


        public async Task<ResponseDto<NoContent>> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
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