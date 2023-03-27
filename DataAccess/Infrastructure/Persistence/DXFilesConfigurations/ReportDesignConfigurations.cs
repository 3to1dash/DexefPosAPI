using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class ReportDesignConfigurations : IEntityTypeConfiguration<ReportDesign>
{
    public void Configure(EntityTypeBuilder<ReportDesign> builder)
    {
        builder.ToTable("ReportDesign");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.Copies).HasDefaultValueSql("((0))");
        builder.Property(e => e.GroupId).HasColumnName("GroupID");
        builder.Property(e => e.LstUpdate)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
        builder.Property(e => e.Name).HasMaxLength(150);
        builder.Property(e => e.Printer)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.ReportName).HasMaxLength(150);
        builder.Property(e => e.ReportType).HasMaxLength(50);
        builder.Property(e => e.Size).HasMaxLength(50);
        builder.Property(e => e.TemplateId).HasColumnName("TemplateID");
        builder.Property(e => e.TransactionName).HasMaxLength(50);
        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}