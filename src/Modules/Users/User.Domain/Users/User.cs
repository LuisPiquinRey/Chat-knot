using User.Domain.Abstractions;
using User.Domain.Users.Events;

namespace User.Domain.Users;

public sealed class User : Entity
{
    public User(Guid id) : base(id) { }
    public string? Username { get; private set; }
    public string? Password { get; private set; }
    public string? Email { get; private set; }
    public DateTime createdAt { get; private set; }
    public bool? isAdmin { get; private set; }
    public required Settings Settings { get; private set; }
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
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}