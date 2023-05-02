using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindGroupDefaultConfiguration : IEntityTypeConfiguration<KindGroupDefault>
{
    public void Configure(EntityTypeBuilder<KindGroupDefault> builder)
    {
        builder.ToTable("KindGroup_Default");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Address1).HasMaxLength(50);

        builder.Property(e => e.Address2).HasMaxLength(50);

        builder.Property(e => e.Address3).HasMaxLength(50);

        builder.Property(e => e.Discountable).HasDefaultValueSql("((1))");

        builder.Property(e => e.Discountbuy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountbuy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountsale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountsale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExprFormat).HasDefaultValueSql("((0))");

        builder.Property(e => e.ExprMin).HasDefaultValueSql("((0))");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.HasZeroTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsOperate).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdiscountperc)
            .HasColumnName("isdiscountperc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Maximum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Moneyextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("moneyextra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OperateId).HasColumnName("OperateID");

        builder.Property(e => e.PriceIncludeTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReSaleId).HasColumnName("ReSaleID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCostId).HasColumnName("SaleCostID");

        builder.Property(e => e.SaleId).HasColumnName("SaleID");

        builder.Property(e => e.SaleTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Taxable)
            .HasColumnName("taxable")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.VendorId).HasColumnName("VendorID");
    }
}