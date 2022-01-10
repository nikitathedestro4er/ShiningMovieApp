using DTOs.Movie;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class MovieForUpdateDTOValidator : AbstractValidator<MovieForUpdateDTO>
    {
        public MovieForUpdateDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.GenreId).NotEmpty();
            RuleFor(x => x.DirectorId).NotEmpty();
            RuleFor(x => x.Actors).NotEmpty();
            RuleFor(x => x.Year).NotEmpty().InclusiveBetween(1900, 2021);
            RuleFor(x => x.Rating).NotEmpty().InclusiveBetween(1, 13);
            RuleFor(x => x.Description).NotEmpty();

        }
    }
}
