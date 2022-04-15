using Microsoft.AspNetCore.Mvc;
using Store_Dapper.DTOs;

namespace Store_Dapper.Controllers
{
    
    public class BookController:ControllerCustomBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            return Ok();
        }
        [HttpPost]
        public IActionResult Create([FromBody] CustomerDto customer){
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] CustomerDto customer)
        {return Ok();}
        
         [HttpDelete("{id}")]
        public IActionResult Remove(int id){
            return Ok();
        }
    }
}