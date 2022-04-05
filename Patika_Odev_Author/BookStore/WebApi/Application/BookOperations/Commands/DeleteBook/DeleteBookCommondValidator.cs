using FluentValidation;

namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(Command => Command.BookId).GreaterThan(0);
        }
    }
}