using MediatR;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Application.BookOperations.Queries.GetAll
{
    public class BookGetAllQueryHandler: IRequestHandler<BookGetAllQuery, ResponseDto<List<BookDto>>>
    {
        private readonly IBookRepository _repository;

        public BookGetAllQueryHandler(IBookRepository repository)
        {
            _repository =repository;
        }

        public async Task<ResponseDto<List<BookDto>>> Handle(BookGetAllQuery request, CancellationToken cancellationToken)
        {
            var books = await _repository.GetAll();

            var booksDtos = new List<BookDto>();

            books.ForEach(x => booksDtos.Add(new BookDto(){Id=x.Id,Name=x.Name,Price=x.Price,Stock=x.Stock}));

            return ResponseDto<List<BookDto>>.Success(booksDtos, 200);
        }

        Task<ResponseDto<List<BookDto>>> IRequestHandler<BookGetAllQuery, ResponseDto<List<BookDto>>>.Handle(BookGetAllQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}