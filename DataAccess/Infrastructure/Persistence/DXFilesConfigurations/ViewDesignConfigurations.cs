using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class ViewDesignConfigurations : IEntityTypeConfiguration<ViewDesign>
{
    public void Configure(EntityTypeBuilder<ViewDesign> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_Reports_Design");

        builder.ToTable("View_Design");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Dealing).HasMaxLength(50);
        builder.Property(e => e.DesignName).HasMaxLength(350);
        builder.Property(e => e.FrmName).HasMaxLength(50);
        builder.Property(e => e.IsDefault).HasDefaultValueSql("((0))");
        builder.Property(e => e.TableName)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");
        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}