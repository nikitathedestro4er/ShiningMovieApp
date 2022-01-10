using DTOs.Comment;
using FluentValidation;

namespace Services.Validators
{
    public class CommentDTOValidator : AbstractValidator<CommentDTO>
    {
        public CommentDTOValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.MovieId).NotEmpty();
            RuleFor(x => x.Content).NotEmpty();
        }
    }
}