using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

internal class ReportDesignPrefrenceConfigurations : IEntityTypeConfiguration<ReportDesignPrefrence>
{
    public void Configure(EntityTypeBuilder<ReportDesignPrefrence> builder)
    {
        builder.ToTable("ReportDesign_Prefrence");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("ID");
        builder.Property(e => e.ReportId).HasColumnName("ReportID");
        builder.Property(e => e.Type).HasMaxLength(50);
        builder.Property(e => e.Value).HasMaxLength(50);
    }
}