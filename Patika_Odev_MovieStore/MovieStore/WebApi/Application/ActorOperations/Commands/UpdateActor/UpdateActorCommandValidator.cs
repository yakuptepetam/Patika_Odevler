using FluentValidation;

namespace WebApi.Application.ActorOperations.Commands.UpdateActor
{
    public class UpdateActorCommandValidator : AbstractValidator<UpdateActorCommand>
    {
        public UpdateActorCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).MinimumLength(4).When(x => x.Model.Name != string.Empty);
            RuleFor(Command => Command.Model.Surname).MinimumLength(4).When(x => x.Model.Surname != string.Empty);
            RuleFor(Command => Command.Model.BirthOfDate).MinimumLength(4).When(x => x.Model.BirthOfDate != string.Empty);
        }
    }
}