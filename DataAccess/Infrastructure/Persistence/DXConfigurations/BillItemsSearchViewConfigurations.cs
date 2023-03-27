using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillItemsSearchViewConfiguration : IEntityTypeConfiguration<BillItemsSearchView>
{
    public void Configure(EntityTypeBuilder<BillItemsSearchView> builder)
    {
        builder.HasNoKey();

        builder.ToView("BillItemsSearchView");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Address).HasMaxLength(50);

        builder.Property(e => e.Address1).HasMaxLength(50);

        builder.Property(e => e.Address2).HasMaxLength(50);

        builder.Property(e => e.BillExtra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillIndex).HasColumnName("Bill_index");

        builder.Property(e => e.Bounes).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ChargeDiscount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ChargeDiscountPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CostCenter).HasMaxLength(150);

        builder.Property(e => e.CostIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CostOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Customer).HasMaxLength(400);

        builder.Property(e => e.CustomerGroup).HasMaxLength(400);

        builder.Property(e => e.Dat)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DAT");

        builder.Property(e => e.Datperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DATPerc");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountAfterTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountCash).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountCashPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountGroup).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountPormotion).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountTrade).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Discountbuy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountbuy");

        builder.Property(e => e.Discountsale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountsale");

        builder.Property(e => e.DisountBounes).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DisountBounesPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtImport).HasColumnType("datetime");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ExtraCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ExtraCostPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ExtraPormotion).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FixedSale).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.GroupCode)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.GuaranteePeriod).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.InvoiceTxt1).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt2).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt3).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt4).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt5).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt6).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt7).HasMaxLength(300);

        builder.Property(e => e.InvoiceTxt8).HasMaxLength(300);

        builder.Property(e => e.IsDat).HasColumnName("IsDAT");

        builder.Property(e => e.Isdiscountperc).HasColumnName("isdiscountperc");

        builder.Property(e => e.Isfree).HasColumnName("ISFree");

        builder.Property(e => e.ItemCode).HasMaxLength(50);

        builder.Property(e => e.ItemCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ItemNameEn).HasColumnName("ItemNameEN");

        builder.Property(e => e.ItemPoints).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ItemTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ItemTxt1).HasMaxLength(150);

        builder.Property(e => e.ItemTxt2).HasMaxLength(150);

        builder.Property(e => e.ItemTxt3).HasMaxLength(150);

        builder.Property(e => e.ItemTxt4).HasMaxLength(150);

        builder.Property(e => e.ItemTxt5).HasMaxLength(150);

        builder.Property(e => e.ItemTxt6).HasMaxLength(150);

        builder.Property(e => e.ItemTxt7).HasMaxLength(150);

        builder.Property(e => e.ItemTxt8).HasMaxLength(150);

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.KindCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.KuSale).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Kupurchase)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("KUPurchase");

        builder.Property(e => e.LinPrice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("linPrice");

        builder.Property(e => e.LinQty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("linQty");

        builder.Property(e => e.LinUnite).HasMaxLength(50);

        builder.Property(e => e.Lindt)
            .HasColumnType("datetime")
            .HasColumnName("lindt");

        builder.Property(e => e.LoutDt).HasColumnType("datetime");

        builder.Property(e => e.LoutPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LoutQty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("loutQty");

        builder.Property(e => e.LoutUnite).HasMaxLength(50);

        builder.Property(e => e.Maximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.NetPrice).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.NetTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.OperatingId).HasColumnName("OperatingID");

        builder.Property(e => e.OrderCounts).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Ordered).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Price1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price1");

        builder.Property(e => e.Price2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price2");

        builder.Property(e => e.Price3)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price3");

        builder.Property(e => e.Price4)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price4");

        builder.Property(e => e.Price5)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price5");

        builder.Property(e => e.Price6)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price6");

        builder.Property(e => e.Price7)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price7");

        builder.Property(e => e.Price8)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price8");

        builder.Property(e => e.PriceAfterDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PricingMode)
            .HasMaxLength(4)
            .IsUnicode(false);

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty1IN");

        builder.Property(e => e.Qty1Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty2).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty2In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty2IN");

        builder.Property(e => e.Qty2Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Quota).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Quote).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.RepMan).HasMaxLength(50);

        builder.Property(e => e.Requested).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Reserved).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RewardPoint).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RewardPoints).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.SaleCostId).HasColumnName("SaleCostID");

        builder.Property(e => e.SaleId).HasColumnName("SaleID");

        builder.Property(e => e.SalePrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.SaleReturnId).HasColumnName("SaleReturnID");

        builder.Property(e => e.ScId).HasColumnName("ScID");

        builder.Property(e => e.Serialcount)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("serialcount");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.StoreName).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxName).HasMaxLength(50);

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ToStore).HasMaxLength(50);

        builder.Property(e => e.ToStoreId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ToStoreID");

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalExtra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalVal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferAsk).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferNeed).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.UniteQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UsageId).HasColumnName("UsageID");

        builder.Property(e => e.VendorCode).HasMaxLength(50);

        builder.Property(e => e.VendorName).HasMaxLength(400);
    }
}