using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.BookOperations.Commands.Create
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, ResponseDto<int>>
    {  private readonly IBookRepository _bookRepository;
        private readonly IMediator _mediator;
        public CreateBookCommandHandler(IBookRepository bookRepository, IMediator mediator)
        {
            _bookRepository = bookRepository;
            _mediator = mediator;
        }

       
        public async Task<ResponseDto<int>> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            int id=await _bookRepository.Save(request);
            return ResponseDto<int>.Success(id,201);
        
        }
    }
}