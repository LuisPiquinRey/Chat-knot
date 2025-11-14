using MediatR;
namespace User.Application.Users.Abstractions;
public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}