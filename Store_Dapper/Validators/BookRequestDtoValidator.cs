using FluentValidation;
using Store_Dapper.DTOs;
using Store_Dapper.Repositores;

namespace Store_Dapper.Validators
{
    public class BookRequestDtoValidator: AbstractValidator<BookRequestDto>
    {
        private readonly IBookRepository _repository;

        public BookRequestDtoValidator(IBookRepository repository)
        {
            RuleFor(x=>x.Price).GreaterThan(-1).WithMessage("Bir ücret belirlemelisiniz ve 0 ya da daha büyük olmalı.");
            RuleFor(x=>x.Name).NotNull().MinimumLength(2);
            RuleFor(x=>x.Stock).GreaterThan(-1).LessThan(10000).WithMessage("Bir ürünün maksimum stoğu 10bindir");
            _repository = repository;
        }
    }
}