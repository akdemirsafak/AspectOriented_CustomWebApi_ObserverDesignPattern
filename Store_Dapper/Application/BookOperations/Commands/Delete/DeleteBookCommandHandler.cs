using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.BookOperations.Commands.Delete
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, ResponseDto<NoContent>>
    {
        private readonly IBookRepository _bookRepository;
        
        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            
        }

       
        public async Task<ResponseDto<NoContent>> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
              var result = await _bookRepository.Delete(request);

            if (!result)
            {

                return ResponseDto<NoContent>.Fail("silme işlemi başarısız", 500);


            }

            return ResponseDto<NoContent>.Success(204);

        }
    }
}