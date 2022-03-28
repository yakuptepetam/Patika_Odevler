using FluentValidation;

namespace WebApi.BookOperations.DeleteBook
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(Command => Command.BookId).GreaterThan(0);
        }
    }
}