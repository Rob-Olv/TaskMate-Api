using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskMate.Domain;

namespace TaskMate.Infrastructure
{
    public class ImageConfig : BaseDomainConfig<Image>
    {
        public ImageConfig(): base("image") { }

        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
            builder.OwnsOne(x => x.Path, path =>
            {
                path.Property(e => e.Value)
                    .HasColumnName("path")
                    .HasMaxLength(100)
                    .IsRequired();
            });
            builder.Property(x => x.Status).HasColumnName("status").IsRequired();

            builder.Property(x => x.TaskId).HasColumnName("taskId").IsRequired();
            builder.HasOne(x => x.Task).WithMany(x => x.Imagens).HasForeignKey(x => x.TaskId);
        }
    }
}
