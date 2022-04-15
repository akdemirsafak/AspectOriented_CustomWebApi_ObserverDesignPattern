
using AspectOrientedP.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspectOrientedP.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


//PostSharp ile aşağıdaki gibi kullanımlar söz konusu olabiliyor fakat ücretli olduğu için kullanmıyoruz.
// [LogExceptionHandlingAspect]
// [CheckUserAuthorizationAspect]
// [LogProcessAspect]
// [CacheAspect(TimeOut = 10000)]
[HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetCustomers();
            return Ok(customers);
        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            return Ok(customer);
        }

     

    }
}