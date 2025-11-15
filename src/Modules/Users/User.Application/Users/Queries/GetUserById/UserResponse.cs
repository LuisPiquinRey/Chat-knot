namespace User.Application.Users.Queries.GetUserByIdQuery;
public sealed class UserResponse
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}