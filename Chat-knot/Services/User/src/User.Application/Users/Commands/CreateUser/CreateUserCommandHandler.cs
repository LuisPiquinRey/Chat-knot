using User.Application.Users.Abstractions;
using User.Domain.Users;
namespace User.Application.Users.Commands.CreateUser;
public sealed class CreateUserCommandHandler
    : ICommandHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _repository;

    public CreateUserCommandHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<Guid>> Handle(
        CreateUserCommand request,
        CancellationToken cancellationToken)
    {
        var user = User.Create(
            new Username(request.Username),
            new Password(request.Password),
            new Email(request.Email),
            request.IsAdmin,
            new Settings() 
        );

        _repository.Add(user);

        await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success(user.Id);
    }
}