using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class ReportDesignEntryConfigurations : IEntityTypeConfiguration<ReportDesignEntry>
{
    public void Configure(EntityTypeBuilder<ReportDesignEntry> builder)
    {
        builder.ToTable("ReportDesign_Entry");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.ParentId).HasColumnName("ParentID");
        builder.Property(e => e.SubId).HasColumnName("SubID");
    }
}