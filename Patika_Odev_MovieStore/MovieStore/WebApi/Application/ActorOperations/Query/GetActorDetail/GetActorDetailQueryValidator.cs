using FluentValidation;

namespace WebApi.Application.ActorOperations.Query.GetActorDetail
{
    public class GetActorDetailQueryValidator : AbstractValidator<GetActorDetailQuery>
    {
        public GetActorDetailQueryValidator()
        {
            RuleFor(query => query.ActorId).GreaterThan(0);
        }
    }
}