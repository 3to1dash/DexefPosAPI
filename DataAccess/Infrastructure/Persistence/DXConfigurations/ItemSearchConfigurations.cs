using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemSearchConfiguration : IEntityTypeConfiguration<ItemSearch>
{
    public void Configure(EntityTypeBuilder<ItemSearch> builder)
    {
        builder.HasNoKey();

        builder.ToView("ItemSearch");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.ActiveFrom).HasColumnType("datetime");

        builder.Property(e => e.Address).HasMaxLength(50);

        builder.Property(e => e.Address1).HasMaxLength(50);

        builder.Property(e => e.Address2).HasMaxLength(50);

        builder.Property(e => e.ArNameO).HasMaxLength(50);

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.ChNameO).HasMaxLength(150);

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.ComId).HasColumnName("Com_ID");

        builder.Property(e => e.CostIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CostOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.DatId).HasColumnName("DatID");

        builder.Property(e => e.DatPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Discountbuy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountbuy");

        builder.Property(e => e.Discountsale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountsale");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EnNameO).HasMaxLength(50);

        builder.Property(e => e.ExprDt).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FixedCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FixedSale).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FrNameO).HasMaxLength(150);

        builder.Property(e => e.Gpccode)
            .HasMaxLength(50)
            .HasColumnName("GPCCode");

        builder.Property(e => e.Gstype)
            .HasMaxLength(50)
            .HasColumnName("GSType");

        builder.Property(e => e.GuaranteePeriod).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Isdiscountperc).HasColumnName("isdiscountperc");

        builder.Property(e => e.KindBarcode)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.KindCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Kindindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindindex");

        builder.Property(e => e.Levels)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("levels");

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

        builder.Property(e => e.Masterbuy).HasColumnName("masterbuy");

        builder.Property(e => e.Mastersale).HasColumnName("mastersale");

        builder.Property(e => e.Maximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Moneyextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("moneyextra");

        builder.Property(e => e.OpenBalance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenQty1).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenQty2).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OpenRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.OpenTaskId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("OpenTaskID");

        builder.Property(e => e.OpenUnite).HasMaxLength(50);

        builder.Property(e => e.OperatingId).HasColumnName("OperatingID");

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

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

        builder.Property(e => e.PurchaseTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty1In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty1IN");

        builder.Property(e => e.Qty1Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty2In)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Qty2IN");

        builder.Property(e => e.Qty2Out).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyIn).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.QtyOut).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RewardPoint).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RoNameO).HasMaxLength(150);

        builder.Property(e => e.RuNameO).HasMaxLength(150);

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale");

        builder.Property(e => e.SaleCostId).HasColumnName("SaleCostID");

        builder.Property(e => e.SaleId).HasColumnName("SaleID");

        builder.Property(e => e.SaleReturnId).HasColumnName("SaleReturnID");

        builder.Property(e => e.Saletax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Serialcount)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("serialcount");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.Store)
            .HasMaxLength(50)
            .HasColumnName("store");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Taxable).HasColumnName("taxable");

        builder.Property(e => e.TotalVal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TuNameO).HasMaxLength(150);

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.UniteQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UrNameO).HasMaxLength(150);

        builder.Property(e => e.VendorId).HasColumnName("VendorID");
    }
}