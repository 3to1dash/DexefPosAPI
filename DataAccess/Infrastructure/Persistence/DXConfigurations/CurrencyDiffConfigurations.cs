using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencyDiffConfiguration : IEntityTypeConfiguration<CurrencyDiff>
{
    public void Configure(EntityTypeBuilder<CurrencyDiff> builder)
    {
        builder.ToTable("CurrencyDiff");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Loss).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LossId).HasColumnName("LossID");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Profit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ProfitId).HasColumnName("ProfitID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}