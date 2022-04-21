using FluentValidation;

namespace WebApi.Application.ActorOperations.Commands.CreateActor
{
    public class CreateActorCommandValidator : AbstractValidator<CreateActorCommand>
    {
        public CreateActorCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.Surname).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.BirthOfDate).NotEmpty();
        }
    }
}