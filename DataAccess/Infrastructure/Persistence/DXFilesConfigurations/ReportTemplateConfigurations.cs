using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

internal class ReportTemplateConfigurations : IEntityTypeConfiguration<ReportTemplate>
{
    public void Configure(EntityTypeBuilder<ReportTemplate> builder)
    {
        builder.ToTable("ReportTemplate");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Name).HasMaxLength(50);
        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}