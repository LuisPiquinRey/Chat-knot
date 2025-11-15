using User.Domain.Abstractions;

namespace User.Domain.Users;
public static class UserErrors
{
    public static Error NotFound = new(
        "User.Found", "The user with the specified identifier not fount");
    public static Error AlreadyExists = new(
        "User.AlreadyExists", "The user already exists on database");
}