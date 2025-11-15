using System;
using User.Application.Users.Abstractions;
namespace User.Application.Users.Commands.CreateUser;
public record CreateUserCommand(
    Guid id,
    string Username,
    string Password,
    string Email
) : ICommand<Guid>;