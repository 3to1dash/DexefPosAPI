using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class LayoutFileConfigurations : IEntityTypeConfiguration<LayoutFile>
{
    public void Configure(EntityTypeBuilder<LayoutFile> builder)
    {
        builder.ToTable("Layout_Files");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.DesignName).HasMaxLength(50);
        builder.Property(e => e.LayoutId).HasColumnName("LayoutID");
    }
}