using System;
using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.Surname).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.BirthOfDate).NotEmpty();
        }
    }
}