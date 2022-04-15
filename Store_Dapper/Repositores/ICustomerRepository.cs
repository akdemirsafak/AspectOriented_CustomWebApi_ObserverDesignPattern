using Store_Dapper.Application.CustomerOperations.Commands.Delete;
using Store_Dapper.Application.CustomerOperations.Commands.Create;

using Store_Dapper.Application.CustomerOperations.Commands.Update;
using Store_Dapper.Models;

namespace Store_Dapper.Repositores
{
    public interface ICustomerRepository
    {
         
        Task<List<Customer>> GetAll();

        Task<List<Customer>> GetById(int id);
        

        Task<int> Save(CreateCustomerCommand createCommand);

        Task<bool> Update(UpdateCustomerCommand updateCommmand);

        Task<bool> Delete(DeleteCustomerCommand deleteCommand);

    }
}