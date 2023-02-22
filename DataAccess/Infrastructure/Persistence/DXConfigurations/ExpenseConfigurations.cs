using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
{


    public void Configure(EntityTypeBuilder<Expense> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.ClassId)
            .HasColumnName("ClassID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dafter)
            .HasMaxLength(50)
            .HasColumnName("dafter");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(600);

        builder.Property(e => e.Num)
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ReNum).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}