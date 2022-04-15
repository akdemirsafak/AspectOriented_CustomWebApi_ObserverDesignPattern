using FluentValidation;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Validators
{
    public class CustomerRequestDtoValidator:AbstractValidator<CustomerRequestDto>
    {
        private readonly ICustomerRepository _repository;
        public CustomerRequestDtoValidator(ICustomerRepository repository)
        {
            RuleFor(x=>x.Name).NotNull().NotEmpty().MinimumLength(2).WithMessage("2 Karakterden Kısa olamaz");
            RuleFor(x=>x.LastName).NotNull().MinimumLength(3).WithMessage("3 Karakterden Kısa olamaz");
            RuleFor(x=>x.Balance).GreaterThan(-1).WithMessage("Bakiye - olamaz");
            
            _repository = repository;
        }


    }
}