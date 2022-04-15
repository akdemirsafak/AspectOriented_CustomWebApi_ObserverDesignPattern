using Store_Dapper.Application.BookOperations.Commands.Create;
using Store_Dapper.Application.BookOperations.Commands.Delete;
using Store_Dapper.Application.BookOperations.Commands.Update;
using Store_Dapper.Models;

namespace Store_Dapper.Repositores
{
    public class BookRepository : IBookRepository
    {
        public Task<bool> Delete(DeleteBookCommand deleteCommand)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CreateBookCommand createCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UpdateBookCommand updateCommmand)
        {
            throw new NotImplementedException();
        }
    }
}