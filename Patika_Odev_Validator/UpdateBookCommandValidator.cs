using FluentValidation;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(Command => Command.BookId).GreaterThan(0);
            RuleFor(Command => Command.Model.GenreId).GreaterThan(0);
            RuleFor(Command => Command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}