using MediatR;
namespace User.Domain.Abstractions;
/*
 * A publisher agent publishes a domain event, and one or more
 * subscribers will be listening to this event to trigger certain
 * logic.
 */
public interface IDomainEvent : INotification
{

}