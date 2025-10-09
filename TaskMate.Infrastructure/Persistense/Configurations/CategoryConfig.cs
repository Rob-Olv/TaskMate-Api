using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskMate.Domain;

namespace TaskMate.Infrastructure
{
    public class CategoryConfig : BaseDomainConfig<Category>
    {
        public CategoryConfig() : base("category") { }

        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(100).IsRequired();

            builder.Property(x => x.UserId).HasColumnName("userId").IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Categories).HasForeignKey(x => x.UserId);
        }
    }
}
