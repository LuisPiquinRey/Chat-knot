using User.Domain.Abstractions;
namespace User.Domain.Users.Events;
public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;