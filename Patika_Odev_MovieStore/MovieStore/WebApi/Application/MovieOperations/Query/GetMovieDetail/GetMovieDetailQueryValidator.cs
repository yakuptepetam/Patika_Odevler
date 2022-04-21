using FluentValidation;

namespace WebApi.Application.MovieOperations.Query.GetMovieDetail
{
    public class GetMovieDetailQueryValidator : AbstractValidator<GetMovieDetailQuery>
    {
        public GetMovieDetailQueryValidator()
        {
            RuleFor(query => query.MovieId).GreaterThan(0);
        }
    }
}