using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportCenterConfiguration : IEntityTypeConfiguration<ReportCenter>
{
    public void Configure(EntityTypeBuilder<ReportCenter> builder)
    {
        builder.ToTable("ReportCenter");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(255);

        builder.Property(e => e.CategoryId)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("CategoryID");

        builder.Property(e => e.ChName).HasMaxLength(255);

        builder.Property(e => e.EnName).HasMaxLength(255);

        builder.Property(e => e.FrName).HasMaxLength(255);

        builder.Property(e => e.Frm).HasMaxLength(255);

        builder.Property(e => e.Hidden).HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.RoName).HasMaxLength(255);

        builder.Property(e => e.RuName).HasMaxLength(255);

        builder.Property(e => e.TableName).HasMaxLength(50);

        builder.Property(e => e.Tags).HasMaxLength(255);

        builder.Property(e => e.Tbl).HasMaxLength(255);

        builder.Property(e => e.TblEntry)
            .HasMaxLength(255)
            .HasColumnName("Tbl_Entry");

        builder.Property(e => e.TuName).HasMaxLength(255);
    }
}