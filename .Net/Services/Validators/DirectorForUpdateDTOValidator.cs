using DTOs.Director;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
   
    public class DirectorForUpdateDTOValidator : AbstractValidator<DirectorForUpdateDTO>
    {
        public DirectorForUpdateDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Birthday).NotEmpty();
            RuleFor(x => x.Rating).NotEmpty().InclusiveBetween(1, 13);
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
