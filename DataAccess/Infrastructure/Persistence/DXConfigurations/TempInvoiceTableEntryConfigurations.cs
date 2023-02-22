using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempInvoiceTableEntryConfiguration : IEntityTypeConfiguration<TempInvoiceTableEntry>
{


    public void Configure(EntityTypeBuilder<TempInvoiceTableEntry> builder)
    {
        builder.HasNoKey();

        builder.ToTable("TempINvoiceTableEntry");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BatchId).HasColumnName("BatchID");

        builder.Property(e => e.BillExtra).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.BillIndex).HasColumnName("Bill_index");

        builder.Property(e => e.Bounes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ChargeDiscount)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ChargeDiscountPerc)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.ColorId).HasColumnName("ColorID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("currency");

        builder.Property(e => e.Dat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("DAT");

        builder.Property(e => e.Datperc)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("DATPerc");

        builder.Property(e => e.DattaxId).HasColumnName("DATTaxID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.DealingType)
            .HasMaxLength(5)
            .IsUnicode(false);

        builder.Property(e => e.Discount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountAfterTax).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountCash).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountCashPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountGroup).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountPormotion).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiscountTrade).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DisountBounes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DisountBounesPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtImport).HasColumnType("datetime");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ExtraCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ExtraCostPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ExtraPormotion).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.FreeDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.InsuranceDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.InsurancePerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.IsDat).HasColumnName("IsDAT");

        builder.Property(e => e.Isdiscountperc).HasColumnName("isdiscountperc");

        builder.Property(e => e.Isfree).HasColumnName("ISFree");

        builder.Property(e => e.Isin).HasColumnName("ISIN");

        builder.Property(e => e.ItemCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.ItemPoints).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ItemShip).IsUnicode(false);

        builder.Property(e => e.KindId).HasColumnName("kindID");

        builder.Property(e => e.Maximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.NetPrice).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.NetTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.Operate)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.Price).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PriceAfterDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Qty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Qty1).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Qty2).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Quota).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.RepTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("RepTaskID");

        builder.Property(e => e.RepVendTask).HasColumnType("numeric(19, 15)");

        builder.Property(e => e.RepVendorSliceId).HasColumnName("RepVendorSliceID");

        builder.Property(e => e.RewardPoints).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.SalePrice).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Ship).IsUnicode(false);

        builder.Property(e => e.SizeId).HasColumnName("SizeID");

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.StatusId).HasColumnName("StatusID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StyleId).HasColumnName("StyleID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ToStoreId).HasColumnName("ToStoreID");

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalExtra).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TranCode)
            .HasMaxLength(5)
            .IsUnicode(false);

        builder.Property(e => e.Txt1)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasColumnName("txt8");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.UniteQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.VendorId).HasColumnName("VendorID");
    }
}