using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StoreAdjustmentConfiguration : IEntityTypeConfiguration<StoreAdjustment>
{


    public void Configure(EntityTypeBuilder<StoreAdjustment> builder)
    {
        builder.ToTable("StoreAdjustment");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DeletedBy).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.IsCredit).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCount).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Prefix)
            .HasMaxLength(20)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

        builder.Property(e => e.Printed).HasDefaultValueSql("((0))");

        builder.Property(e => e.PrintedBy).HasMaxLength(50);

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Reviewed).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReviewedBy).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}