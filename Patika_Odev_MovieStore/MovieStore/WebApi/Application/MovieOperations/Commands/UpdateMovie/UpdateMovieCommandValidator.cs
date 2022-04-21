using System;
using FluentValidation;

namespace WebApi.Application.MovieOperations.Commands.UpdateMovie
{
    public class UpdateMovieCommandValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieCommandValidator()
        {
            RuleFor(Command => Command.MovieId).GreaterThan(0);
            RuleFor(Command => Command.Model.GenreId).GreaterThan(0);
            RuleFor(Command => Command.Model.ActorId).GreaterThan(0);
            RuleFor(Command => Command.Model.DirectorId).GreaterThan(0);
            RuleFor(Command => Command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(Command => Command.Model.Year.Date).NotEmpty().LessThan(DateTime.Now.Date);
        }
    }
}