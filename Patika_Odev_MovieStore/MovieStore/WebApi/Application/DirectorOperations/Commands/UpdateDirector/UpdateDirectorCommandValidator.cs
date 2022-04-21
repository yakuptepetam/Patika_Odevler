using FluentValidation;

namespace WebApi.Application.DirectorOperations.Commands.UpdateDirector
{
    public class UpdateDirectorCommandValidator : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).MinimumLength(4).When(x => x.Model.Name != string.Empty);
            RuleFor(Command => Command.Model.Surname).MinimumLength(4).When(x => x.Model.Surname != string.Empty);
            RuleFor(Command => Command.Model.BirthOfDate).MinimumLength(4).When(x => x.Model.BirthOfDate != string.Empty);
        }
    }
}