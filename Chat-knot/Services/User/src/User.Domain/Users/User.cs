namespace User.Domain.Users;
public sealed class User
{
    public Guid Id { get; private set; }
    public string? Username { get; private set; }
    public string? Password { get;private set; }
    public string? Email { get; private set; }
    public LocalDate createdAt { get; private set; }
}