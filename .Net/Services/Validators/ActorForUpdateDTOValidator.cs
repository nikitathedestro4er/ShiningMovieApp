using DTOs.Actor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class ActorForUpdateDTOValidator : AbstractValidator<ActorForUpdateDTO>
    {
        public ActorForUpdateDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Birthday).NotEmpty();
            RuleFor(x => x.Rating).NotEmpty().InclusiveBetween(1, 13);
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
