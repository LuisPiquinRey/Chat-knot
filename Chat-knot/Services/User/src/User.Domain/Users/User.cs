using User.Domain.Abstractions;

namespace User.Domain.Users;

public sealed class User : Entity
{
    private User(
        Guid id,
        Username username,
        Password password,
        Email email,
        IsAdmin isAdmin,
        Settings settings) : base(id)
    {
        Username = username;
        Password = password;
        Email = email;
        IsAdmin = isAdmin;
        Settings = settings;
    }

    public Username Username { get; private set; }
    public Password Password { get; private set; }
    public Email Email { get; private set; }
    public IsAdmin IsAdmin { get; private set; }
    public Settings Settings { get; private set; }

    public static User Create(
        Username username,
        Password password,
        Email email,
        IsAdmin isAdmin,
        Settings settings)
    {
        var user = new User(
            Guid.NewGuid(),
            username,
            password,
            email,
            isAdmin,
            settings);

        return user;
    }
}