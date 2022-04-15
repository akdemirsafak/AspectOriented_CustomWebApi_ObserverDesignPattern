using Store_Dapper.Application.BookOperations.Commands.Create;
using Store_Dapper.Application.BookOperations.Commands.Delete;
using Store_Dapper.Application.BookOperations.Commands.Update;
using Store_Dapper.Models;

namespace Store_Dapper.Repositores
{
    public interface IBookRepository
    {
        
        Task<List<Book>> GetAll();

        Task<List<Book>> GetById(int id);
        

        Task<int> Save(CreateBookCommand createCommand);

        Task<bool> Update(UpdateBookCommand updateCommmand);

        Task<bool> Delete(DeleteBookCommand deleteCommand);
    }
}