namespace User.Domain.Abstractions;
/*
 * The repository and unit of work patterns are intended to create an abstraction
 * layer between the data access layer and the business logic layer of an application.
 * Implementing these patterns can help insulate your application from changes in the
 * data store and can facilitate automated unit testing or test-driven development (TDD).
 * 
 * The repository pattern is intended to create an abstraction layer between the data access
 * layer and the business logic layer of an application. It is a data access pattern that prompts
 * a more loosely coupled approach to data access. We create the data access logic in a separate class,
 * or set of classes called a repository with the responsibility of persisting the application's business model.

Unit of Work is referred to as a single transaction that involves multiple operations of insert/update/delete
and so on kinds. To say it in simple words, it means that for specific user action (say registration on a website),
all the transactions like insert/update/delete and so on are done in one single transaction, rather than doing multiple
database transactions. This means, one unit of work here involves insert/update/delete operations, all in one single transaction.
 */
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}