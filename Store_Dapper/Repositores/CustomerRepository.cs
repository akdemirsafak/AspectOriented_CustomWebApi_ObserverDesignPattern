using System.Data;
using Store_Dapper.Application.CustomerOperations.Commands.Create;
using Store_Dapper.Application.CustomerOperations.Commands.Delete;
using Store_Dapper.Application.CustomerOperations.Commands.Update;
using Store_Dapper.Models;

namespace Store_Dapper.Repositores
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDbConnection _connection;
        private readonly IDbTransaction _transaction;

        public CustomerRepository(IDbConnection connection, IDbTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public Task<bool> Delete(DeleteCustomerCommand deleteCommand)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CreateCustomerCommand createCommand)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UpdateCustomerCommand updateCommmand)
        {
            throw new NotImplementedException();
        }
    }
}