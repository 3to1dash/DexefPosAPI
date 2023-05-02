using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportTemplateTableConfiguration : IEntityTypeConfiguration<ReportTemplateTable>
{
    public void Configure(EntityTypeBuilder<ReportTemplateTable> builder)
    {
        builder.HasKey(e => e.TableName);

        builder.ToTable("ReportTemplate_Tables");

        builder.Property(e => e.TableName).HasMaxLength(50);

        builder.Property(e => e.Dealing).HasMaxLength(50);
    }
}