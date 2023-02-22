using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{


    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.HasIndex(e => e.IsVisible, "IX_Reports_IsVisible_A514D");

        builder.HasIndex(e => new { e.IsVisible, e.ParentId }, "IX_Reports_IsVisible_ParentID_C28B0");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(255);

        builder.Property(e => e.ChName).HasMaxLength(255);

        builder.Property(e => e.EnName).HasMaxLength(255);

        builder.Property(e => e.FrName).HasMaxLength(255);

        builder.Property(e => e.Frm).HasMaxLength(255);

        builder.Property(e => e.GrpId)
            .HasMaxLength(255)
            .HasColumnName("GrpID");

        builder.Property(e => e.IstopMenu).HasColumnName("ISTopMenu");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.RoName).HasMaxLength(255);

        builder.Property(e => e.RuName).HasMaxLength(255);

        builder.Property(e => e.ShortCut).HasMaxLength(255);

        builder.Property(e => e.TableName).HasMaxLength(50);

        builder.Property(e => e.Tags).HasMaxLength(255);

        builder.Property(e => e.Tbl).HasMaxLength(255);

        builder.Property(e => e.TblEntry)
            .HasMaxLength(255)
            .HasColumnName("Tbl_Entry");

        builder.Property(e => e.TuName).HasMaxLength(255);

        builder.Property(e => e.Xcolor)
            .HasMaxLength(255)
            .HasColumnName("XColor");

        builder.Property(e => e.Ximage)
            .HasMaxLength(255)
            .HasColumnName("XImage");

        builder.HasOne(d => d.PermissionNavigation)
            .WithMany(p => p.Reports)
            .HasForeignKey(d => d.Permission)
            .HasConstraintName("FK_Reports_User_Permission");
    }
}