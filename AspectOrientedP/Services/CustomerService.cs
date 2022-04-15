using AspectOrientedP.Models;

namespace AspectOrientedP.Services
{
    public class CustomerService : ICustomerService
    {
        private static List<Customer> _customer = new List<Customer>()
        {
            new(){ Id=1, Name="Şafak", LastName="Akdemir"},
             new(){ Id=2, Name="Margot", LastName="Robbie"},
              new(){ Id=3, Name="Will", LastName="Smith"},
                new(){ Id=4, Name="Steve", LastName="Harvey"},
              new(){ Id=5, Name="Joey", LastName="Tribbiani"}

        };
        public Customer GetCustomerById(int id)
        {
            return _customer.FirstOrDefault(x => x.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return _customer.ToList();
        }
    }
}