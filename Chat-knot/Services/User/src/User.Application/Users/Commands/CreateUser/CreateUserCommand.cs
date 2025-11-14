using User.Application.Users.Abstractions;
namespace User.Application.Users.Commands.CreateUser;
public record CreateUserCommand(
    string Username,
    string Password,
    string Email
) : IRequest<Result<Guid>>;