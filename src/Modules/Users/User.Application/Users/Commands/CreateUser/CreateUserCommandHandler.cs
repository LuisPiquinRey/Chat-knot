using User.Application.Users.Abstractions;
using User.Domain.Abstractions;
using User.Domain.Users;
namespace User.Application.Users.Commands.CreateUser;
public sealed class CreateUserCommandHandler
    : ICommandHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository repository,IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success(user.Id);
    }
}