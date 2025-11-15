namespace User.Application.Users.Queries.GetUserByIdQuery;
public sealed record GetUserByIdQuery(Guid idUser) : IQuery<UserResponse>;