using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindConfiguration : IEntityTypeConfiguration<Kind>
{
    public void Configure(EntityTypeBuilder<Kind> builder)
    {
        builder.ToTable("kind");

        builder.HasIndex(e => new {e.ParentId, e.TypeIndex}, "IX_kind_ParentID_TypeIndex_1C92C");

        builder.HasIndex(e => new {e.ParentId, e.TypeIndex}, "IX_kind_ParentID_TypeIndex_2C36E");

        builder.HasIndex(e => new {e.TypeIndex, e.Active}, "IX_kind_TypeIndex_active_5A264");

        builder.HasIndex(e => new {e.TypeIndex, e.Active}, "IX_kind_TypeIndex_active_7B522");

        builder.HasIndex(e => new {e.TypeIndex, e.Optkind, e.Active}, "IX_kind_TypeIndex_optkind_active_52662");

        builder.HasIndex(e => e.Optkind, "IX_kind_optkind_8DCA2");

        builder.HasIndex(e => new {e.TypeIndex, e.Optkind, e.Code, e.VendorId}, "NonClusteredIndex-20200113-222411");

        builder.HasIndex(e => new {e.TypeIndex, e.Kindindex}, "missing_index_1139_1138_kind");

        builder.HasIndex(e => new {e.TypeIndex, e.Id}, "missing_index_395_394_kind");

        builder.HasIndex(e => new {e.TypeIndex, e.VendorId, e.Active}, "missing_index_4082_4081_kind");

        builder.HasIndex(e => new {e.TypeIndex, e.Active, e.IsExp}, "missing_index_5256_5255_kind");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.ActiveFrom).HasColumnType("datetime");

        builder.Property(e => e.ArName).HasDefaultValueSql("('')");

        builder.Property(e => e.Barcode)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.ChName).HasDefaultValueSql("('')");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Color).HasDefaultValueSql("((0))");

        builder.Property(e => e.ComId).HasColumnName("Com_ID");

        builder.Property(e => e.DatId).HasColumnName("DatID");

        builder.Property(e => e.DatPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Discountable).HasDefaultValueSql("((1))");

        builder.Property(e => e.Discountbuy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountbuy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountsale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountsale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EnName).HasDefaultValueSql("('')");

        builder.Property(e => e.ExprFormat).HasDefaultValueSql("((0))");

        builder.Property(e => e.ExprMin).HasDefaultValueSql("((0))");

        builder.Property(e => e.FixedCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ForeColor).HasDefaultValueSql("((0))");

        builder.Property(e => e.Gpccode)
            .HasMaxLength(50)
            .HasColumnName("GPCCode");

        builder.Property(e => e.Gstype)
            .HasMaxLength(50)
            .HasColumnName("GSType");

        builder.Property(e => e.GuaranteePeriod)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HasEquation).HasDefaultValueSql("((0))");

        builder.Property(e => e.HasZeroTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.HideFromTouch).HasDefaultValueSql("((0))");

        builder.Property(e => e.IdentityUnite).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsExp).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsOperate).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdiscountperc)
            .HasColumnName("isdiscountperc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindindex");

        builder.Property(e => e.Moneyextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("moneyextra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OperatingId)
            .HasColumnName("OperatingID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.PriceIncludeTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.PricingMode).HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RewardCanReplace).HasDefaultValueSql("((0))");

        builder.Property(e => e.RewardPoint)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RoName).HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName).HasDefaultValueSql("('')");

        builder.Property(e => e.SaleCostId)
            .HasColumnName("SaleCostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.SaleId)
            .HasColumnName("SaleID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.SaleReturnId).HasColumnName("SaleReturnID");

        builder.Property(e => e.Saletax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ScId).HasColumnName("ScID");

        builder.Property(e => e.Serialcount)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("serialcount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Ship).HasDefaultValueSql("('')");

        builder.Property(e => e.Size).HasDefaultValueSql("((0))");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Taxable)
            .HasColumnName("taxable")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TuName).HasDefaultValueSql("('')");

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TypeIndex).HasDefaultValueSql("((0))");

        builder.Property(e => e.UrName).HasDefaultValueSql("('')");

        builder.Property(e => e.UsageId).HasColumnName("UsageID");

        builder.Property(e => e.VendorId)
            .HasColumnName("VendorID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VisibleOrder).HasDefaultValueSql("((0))");
    }
}