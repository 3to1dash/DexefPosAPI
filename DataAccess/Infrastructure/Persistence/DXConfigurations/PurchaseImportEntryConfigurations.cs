using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchaseImportEntryConfiguration : IEntityTypeConfiguration<PurchaseImportEntry>
{
    public void Configure(EntityTypeBuilder<PurchaseImportEntry> builder)
    {
        builder.ToTable("PurchaseImport_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillIndex)
            .HasColumnName("Bill_index")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Bounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Class).HasDefaultValueSql("('')");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency");

        builder.Property(e => e.Custname)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dafter).HasDefaultValueSql("((0))");

        builder.Property(e => e.DattaxId)
            .HasColumnName("DATTaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAcc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAccPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAfterTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountBill)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountGroup)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountableAcc).HasDefaultValueSql("((0))");

        builder.Property(e => e.DisountBounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DisountBounesPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtImport).HasColumnType("datetime");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ExtraCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraCostPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdiscountperc)
            .HasColumnName("isdiscountperc")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Isfree)
            .HasColumnName("ISFree")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCost)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId)
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindid).HasColumnName("kindid");

        builder.Property(e => e.Lenght)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.Operate)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PerfectCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PerfectCostIn)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("PerfectCostIN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PreTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price1)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price2)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PriceIncludeTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Quota)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RepDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.RepId)
            .HasColumnName("RepID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("RepTaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepVendTask)
            .HasColumnType("numeric(19, 15)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepVendorDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.RepVendorSliceId)
            .HasColumnName("RepVendorSliceID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RowCost)
            .HasMaxLength(4000)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasDefaultValueSql("('')");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

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

        builder.Property(e => e.TotalQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.VendorId)
            .HasColumnName("VendorID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Weight)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}