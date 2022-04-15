
using AspectOrientedP.Models;

namespace AspectOrientedP.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        public Customer GetCustomerById(int id);
    
      
    }
}