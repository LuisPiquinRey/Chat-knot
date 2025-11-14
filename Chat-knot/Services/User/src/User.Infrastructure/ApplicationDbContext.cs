using User.Domain.Users;
namespace User.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}