using System;
using FluentValidation;

namespace WebApi.Application.MovieOperations.Commands.CreateMovie
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(Command => Command.Model.GenreId).GreaterThan(0);
            RuleFor(Command => Command.Model.ActorId).GreaterThan(0);
            RuleFor(Command => Command.Model.DirectorId).GreaterThan(0);
            RuleFor(Command => Command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.Year.Date).NotEmpty().LessThan(DateTime.Now.Date);
        }
    }
}