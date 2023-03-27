using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportTableDatumConfiguration : IEntityTypeConfiguration<ReportTableDatum>
{
    public void Configure(EntityTypeBuilder<ReportTableDatum> builder)
    {
        builder.ToTable("Report_TableData");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(150);

        builder.Property(e => e.DealingEn)
            .HasMaxLength(50)
            .HasColumnName("Dealing_En");

        builder.Property(e => e.DisplayName).HasMaxLength(50);

        builder.Property(e => e.DisplayNameEn)
            .HasMaxLength(50)
            .HasColumnName("DisplayName_En");

        builder.Property(e => e.FileId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("FileID");

        builder.Property(e => e.FileName).HasMaxLength(50);

        builder.Property(e => e.GetTable).HasMaxLength(50);

        builder.Property(e => e.GrpName).HasMaxLength(50);

        builder.Property(e => e.Isdefault)
            .HasColumnName("ISDefault")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaperIndex).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PrintCopy).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tablename).HasMaxLength(50);

        builder.Property(e => e.Type).HasMaxLength(50);
    }
}