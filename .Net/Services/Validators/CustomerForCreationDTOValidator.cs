using DTOs.Customer;
using FluentValidation;

namespace Services.Validators
{
    public class CustomerForCreationDTOValidator : AbstractValidator<CustomerForCreationDTO>
    {
        public CustomerForCreationDTOValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}