using DTOs.Customer;
using FluentValidation;

namespace Services.Validators
{
    public class CustomerForUpdateDTOValidator : AbstractValidator<CustomerForUpdateDTO>
    {
        public CustomerForUpdateDTOValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}