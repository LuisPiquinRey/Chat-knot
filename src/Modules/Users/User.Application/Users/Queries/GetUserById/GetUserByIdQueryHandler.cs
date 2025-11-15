using User.Application.Users.Abstractions;
namespace User.Application.Users.Queries.GetUserByIdQuery;
public sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserResponse>
{
    public Task<Result<UserResponse>> Handle(GetUserByIdQuery, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}