using FluentValidation;

namespace WebApi.Application.DirectorOperations.Commands.CreateDirector
{
    public class CreateDirectorCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateDirectorCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.Surname).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.BirthOfDate).NotEmpty();
        }
    }
}