using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxesAdjustConfiguration : IEntityTypeConfiguration<TaxesAdjust>
{
    public void Configure(EntityTypeBuilder<TaxesAdjust> builder)
    {
        builder.ToTable("Taxes_Adjust");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency).HasMaxLength(50);

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dt1)
            .HasColumnType("datetime")
            .HasColumnName("DT1");

        builder.Property(e => e.Dt2)
            .HasColumnType("datetime")
            .HasColumnName("DT2");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(750);

        builder.Property(e => e.PayId).HasColumnName("PayID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReNum).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}