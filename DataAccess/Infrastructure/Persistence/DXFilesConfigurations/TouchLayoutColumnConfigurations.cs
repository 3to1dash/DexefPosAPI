using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

internal class TouchLayoutColumnConfigurations : IEntityTypeConfiguration<TouchLayoutColumn>
{
    public void Configure(EntityTypeBuilder<TouchLayoutColumn> builder)
    {
        builder.ToTable("Touch_LayoutColumn");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.ColName).HasMaxLength(50);
        builder.Property(e => e.Tile).HasMaxLength(50);
    }
}