using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StorageTransformConfiguration : IEntityTypeConfiguration<StorageTransform>
{
    public void Configure(EntityTypeBuilder<StorageTransform> builder)
    {
        builder.ToTable("Storage_Transform");

        builder.HasIndex(e => new {e.BranchId, e.Dafter}, "IX_Storage_Transform_BranchID_Dafter_EFD75");

        builder.HasIndex(e => new {e.BranchId, e.ToBranchId, e.Dt},
            "IX_Storage_Transform_BranchID_ToBranchID_DT_0B462");

        builder.HasIndex(e => new {e.BranchId, e.ToBranchId, e.Dt},
            "IX_Storage_Transform_BranchID_ToBranchID_DT_6C58D");

        builder.HasIndex(e => new {e.BranchId, e.ToBranchId, e.Dt},
            "IX_Storage_Transform_BranchID_ToBranchID_DT_B6011");

        builder.HasIndex(e => e.Dt, "IX_Storage_Transform_DT_1B914");

        builder.HasIndex(e => e.TaskId, "IX_Storage_Transform_TaskID_59EE2");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Attached).HasDefaultValueSql("((0))");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FromId).HasColumnName("FromID");

        builder.Property(e => e.FromRate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.FromTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RefNumber).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Taxes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ToBranchId).HasColumnName("ToBranchID");

        builder.Property(e => e.ToCurrency).HasMaxLength(3);

        builder.Property(e => e.ToId).HasColumnName("ToID");

        builder.Property(e => e.ToRate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ToTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransferId)
            .HasColumnName("TransferID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransferPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TransferPercId)
            .HasColumnName("TransferPercID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransferValue).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("value");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}