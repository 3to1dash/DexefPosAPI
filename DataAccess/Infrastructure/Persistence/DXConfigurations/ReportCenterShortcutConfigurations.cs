using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportCenterShortcutConfiguration : IEntityTypeConfiguration<ReportCenterShortcut>
{
    public void Configure(EntityTypeBuilder<ReportCenterShortcut> builder)
    {
        builder.ToTable("ReportCenter_Shortcut");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.ReportId).HasColumnName("ReportID");
    }
}