using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskMate.Domain;

namespace TaskMate.Infrastructure
{
    public class UserConfig : BaseDomainConfig<User>
    {
        public UserConfig() : base("user") { }

        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();

            builder.OwnsOne(x => x.Email, email =>
            {
                email.Property(e => e.Value)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsRequired();
            });

            builder.Property(x => x.Password).HasColumnName("password").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Active).HasColumnName("active").IsRequired();
        }
    }
}
