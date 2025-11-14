using User.Domain.Abstractions;
namespace User.Domain.Users;
public sealed class User : Entity
{
    public User(Guid id) : base(id) { }
    public string? Username { get; private set; }
    public string? Password { get;private set; }
    public string? Email { get; private set; }
    public DateTime createdAt { get; private set; }
     public bool? isAdmin { get; private set; }
    public required Settings Settings { get; private set; }
}