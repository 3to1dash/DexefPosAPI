using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CashRecievedConfiguration : IEntityTypeConfiguration<CashRecieved>
{


    public void Configure(EntityTypeBuilder<CashRecieved> builder)
    {
        builder.ToTable("Cash_Recieved");

        builder.HasIndex(e => new { e.BillNum, e.BranchId, e.TaskId }, "IX_Cash_Recieved_BillNum_BranchID_TaskID_D7E06");

        builder.HasIndex(e => e.BranchId, "IX_Cash_Recieved_BranchID_49C81");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_104B9");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_1A653");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_1DDAC");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_20AFF");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_3D9D4");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_43721");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_47F92");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_50541");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_7B3CD");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_8B04E");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_BEE58");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.BillNum }, "IX_Cash_Recieved_BranchID_Dt_BillNum_08BB2");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.BillNum }, "IX_Cash_Recieved_BranchID_Dt_BillNum_3D537");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_D256F");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_E55CA");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_ECBD2");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Cash_Recieved_BranchID_Dt_F3EDA");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Total }, "IX_Cash_Recieved_BranchID_Dt_Total_3BB19");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Total }, "IX_Cash_Recieved_BranchID_Dt_Total_6283C");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Total }, "IX_Cash_Recieved_BranchID_Dt_Total_C706B");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Value }, "IX_Cash_Recieved_BranchID_Dt_Value_291F3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Value }, "IX_Cash_Recieved_BranchID_Dt_Value_C56A3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_2EDC3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_30084");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_42140");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_7B5F7");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_BE7D7");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.WrittenBy }, "IX_Cash_Recieved_BranchID_Dt_WrittenBy_D1D32");

        builder.HasIndex(e => new { e.BranchId, e.Updated, e.DeletedBy, e.Dt }, "IX_Cash_Recieved_BranchID_Updated_DeletedBy_Dt_1CFDD");

        builder.HasIndex(e => new { e.BranchId, e.Updated, e.DeletedBy, e.Dt }, "IX_Cash_Recieved_BranchID_Updated_DeletedBy_Dt_C7392");

        builder.HasIndex(e => new { e.BranchId, e.WrittenBy, e.Dt }, "IX_Cash_Recieved_BranchID_WrittenBy_Dt_4322C");

        builder.HasIndex(e => new { e.BranchId, e.WrittenBy, e.Dt }, "IX_Cash_Recieved_BranchID_WrittenBy_Dt_4EB55");

        builder.HasIndex(e => new { e.Currency, e.BranchId, e.Dt }, "IX_Cash_Recieved_Currency_BranchID_Dt_25F87");

        builder.HasIndex(e => new { e.Currency, e.BranchId, e.Dt }, "IX_Cash_Recieved_Currency_BranchID_Dt_4B5F0");

        builder.HasIndex(e => new { e.Currency, e.BranchId, e.Dt }, "IX_Cash_Recieved_Currency_BranchID_Dt_71289");

        builder.HasIndex(e => new { e.Currency, e.BranchId, e.Dt }, "IX_Cash_Recieved_Currency_BranchID_Dt_76F7B");

        builder.HasIndex(e => new { e.Currency, e.BranchId, e.Dt }, "IX_Cash_Recieved_Currency_BranchID_Dt_D1E9B");

        builder.HasIndex(e => new { e.CustId, e.BranchId, e.Dt }, "IX_Cash_Recieved_CustID_BranchID_Dt_A1BAF");

        builder.HasIndex(e => new { e.CustId, e.BranchId, e.Dt }, "IX_Cash_Recieved_CustID_BranchID_Dt_AF0C9");

        builder.HasIndex(e => new { e.CustId, e.BranchId, e.Dt }, "IX_Cash_Recieved_CustID_BranchID_Dt_EB81E");

        builder.HasIndex(e => new { e.CustId, e.BranchId, e.Dt }, "IX_Cash_Recieved_CustID_BranchID_Dt_FC316");

        builder.HasIndex(e => new { e.Dafter, e.BranchId, e.Deleted, e.Updated }, "IX_Cash_Recieved_Dafter_BranchID_Deleted_Updated_8EC3B");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_Cash_Recieved_Deleted_Updated_1C5EF");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_Cash_Recieved_Deleted_Updated_37133");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_Cash_Recieved_Deleted_Updated_AC19A");

        builder.HasIndex(e => new { e.Deleted, e.Updated }, "IX_Cash_Recieved_Deleted_Updated_C533D");

        builder.HasIndex(e => e.Discount, "IX_Cash_Recieved_Discount_9438C");

        builder.HasIndex(e => new { e.Dt, e.TaskId }, "IX_Cash_Recieved_Dt_TaskID_4EFED");

        builder.HasIndex(e => new { e.Dt, e.TaskId }, "IX_Cash_Recieved_Dt_TaskID_E0FDD");

        builder.HasIndex(e => e.Num, "IX_Cash_Recieved_Num_30257");

        builder.HasIndex(e => new { e.Num, e.Deleted, e.Updated }, "IX_Cash_Recieved_Num_Deleted_Updated_02671");

        builder.HasIndex(e => new { e.Num, e.TaskId }, "IX_Cash_Recieved_Num_TaskID_0DC70");

        builder.HasIndex(e => e.TaskId, "IX_Cash_Recieved_TaskID_77B31");

        builder.HasIndex(e => new { e.TaskId, e.Deleted, e.Updated }, "IX_Cash_Recieved_TaskID_Deleted_Updated_DA701");

        builder.HasIndex(e => new { e.Total, e.BranchId, e.Dt }, "IX_Cash_Recieved_Total_BranchID_Dt_95AE2");

        builder.HasIndex(e => new { e.Value, e.BranchId, e.Dt }, "IX_Cash_Recieved_Value_BranchID_Dt_F4CA6");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Attached).HasDefaultValueSql("((0))");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountId)
            .HasColumnName("DiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasMaxLength(500)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.ProcessId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ProcessID");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ReNum)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}