using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class LayoutConfiguration : IEntityTypeConfiguration<Layout>
{
    public void Configure(EntityTypeBuilder<Layout> builder)
    {
        builder.ToTable("layout");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.AddNewDesign).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ColumnChooser).HasDefaultValueSql("((1))");

        builder.Property(e => e.CopyData).HasDefaultValueSql("((1))");

        builder.Property(e => e.CreatedDate).HasColumnType("datetime");

        builder.Property(e => e.DateFormat)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ExportData).HasDefaultValueSql("((1))");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.Frmname)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("frmname");

        builder.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

        builder.Property(e => e.NumberFormat)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.PrintPreview).HasDefaultValueSql("((1))");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Tags)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UpdateDesign).HasDefaultValueSql("((1))");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}