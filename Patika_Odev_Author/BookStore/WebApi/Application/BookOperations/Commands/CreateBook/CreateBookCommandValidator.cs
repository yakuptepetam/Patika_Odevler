using System;
using FluentValidation;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(Command => Command.Model.GenreId).GreaterThan(0);
            RuleFor(Command => Command.Model.PageCount).GreaterThan(0);
            RuleFor(Command => Command.Model.PublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(Command => Command.Model.Title).NotEmpty().MinimumLength(4);
        }
    }
}