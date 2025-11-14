using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Domain.Users;

namespace User.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                   .HasConversion(
                       v => v.Value,
                       v => new Username(v)
                   )
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(u => u.Password)
                   .HasConversion(
                       v => v.Value,
                       v => new Password(v)
                   )
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasConversion(
                       v => v.Value,
                       v => new Email(v)
                   )
                   .HasMaxLength(200)
                   .IsRequired();

            builder.Property(u => u.IsAdmin)
                   .IsRequired();

            builder.OwnsOne(u => u.Settings, settings =>
            {
                settings.Property(s => s.Theme).HasMaxLength(20);
            });
        }
    }
}