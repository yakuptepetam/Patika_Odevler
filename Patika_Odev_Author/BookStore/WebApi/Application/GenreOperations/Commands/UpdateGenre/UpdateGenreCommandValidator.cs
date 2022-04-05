using FluentValidation;

namespace WebApi.Application.GenreOperations.Commands.UpdateGenre
{
    public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(Command => Command.Model.Name).MinimumLength(4).When(x => x.Model.Name != string.Empty);
        }
    }
}