using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskMate.Domain;

namespace TaskMate.Infrastructure
{
    public class TaskConfig : BaseDomainConfig<Domain.Task>
    {
        public TaskConfig() : base("task") { }

        public override void Configure(EntityTypeBuilder<Task> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Title).HasColumnName("title").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasMaxLength(100).IsRequired();
            builder.Property(x => x.CompletionDate).HasColumnName("completion_date").IsRequired();
            builder.Property(x => x.Priority).HasColumnName("priority");
            builder.Property(x => x.Status).HasColumnName("status").IsRequired();

            builder.Property(x => x.UserId).HasColumnName("userId").IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Tasks).HasForeignKey(x => x.UserId);

            builder.Property(x => x.CategoryId).HasColumnName("categoryId").IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Tasks).HasForeignKey(x => x.CategoryId);

            builder.Property(x => x.ImageId).HasColumnName("imageId").IsRequired();
            builder.
        }
    }
}
