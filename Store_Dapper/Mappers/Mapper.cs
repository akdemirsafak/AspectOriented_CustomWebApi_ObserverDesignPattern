using AutoMapper;
using Store_Dapper.DTOs;
using Store_Dapper.Models;

namespace Store_Dapper.Mappers
{
    public class Mapper:Profile
    {

        public Mapper()
        {
            CreateMap<Book,BookDto>().ReverseMap();
            CreateMap<Customer,CustomerDto>().ReverseMap();
            
        }   
    }
}