using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

internal class TouchLayoutConfigurations : IEntityTypeConfiguration<TouchLayout>
{
    public void Configure(EntityTypeBuilder<TouchLayout> builder)
    {
        builder.ToTable("Touch_Layout");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.IsDefault).HasDefaultValueSql("((0))");
        builder.Property(e => e.Name).HasMaxLength(50);
    }
}