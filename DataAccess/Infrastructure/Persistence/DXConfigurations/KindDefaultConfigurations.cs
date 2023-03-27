using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindDefaultConfiguration : IEntityTypeConfiguration<KindDefault>
{
    public void Configure(EntityTypeBuilder<KindDefault> builder)
    {
        builder.ToTable("kind_default");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.FacIdoperate).HasColumnName("Fac_IDOperate");

        builder.Property(e => e.FacIdreSale).HasColumnName("Fac_IDReSale");

        builder.Property(e => e.FacIdsale).HasColumnName("Fac_IDSale");

        builder.Property(e => e.FacIdsaleCost).HasColumnName("Fac_IDSaleCost");

        builder.Property(e => e.FacIdstock).HasColumnName("Fac_IDStock");

        builder.Property(e => e.HasZeroTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.HonIdreSale).HasColumnName("Hon_IDReSale");

        builder.Property(e => e.HonIdsale).HasColumnName("Hon_IDSale");

        builder.Property(e => e.HonIdsaleCost).HasColumnName("Hon_IDSaleCost");

        builder.Property(e => e.HonIdstock).HasColumnName("Hon_IDStock");

        builder.Property(e => e.LimitExpr).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LimitFixedSale).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LimitMax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LimitOrder).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LotIdreSale).HasColumnName("Lot_IDReSale");

        builder.Property(e => e.LotIdsale).HasColumnName("Lot_IDSale");

        builder.Property(e => e.LotIdsaleCost).HasColumnName("Lot_IDSaleCost");

        builder.Property(e => e.LotIdstock).HasColumnName("Lot_IDStock");

        builder.Property(e => e.MealIdoperate).HasColumnName("Meal_IDOperate");

        builder.Property(e => e.MealIdreSale).HasColumnName("Meal_IDReSale");

        builder.Property(e => e.MealIdsale).HasColumnName("Meal_IDSale");

        builder.Property(e => e.MealIdsaleCost).HasColumnName("Meal_IDSaleCost");

        builder.Property(e => e.MealIdstock).HasColumnName("Meal_IDStock");

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.PriceIncludeTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.ProductIdreSale).HasColumnName("Product_IDReSale");

        builder.Property(e => e.ProductIdsale).HasColumnName("Product_IDSale");

        builder.Property(e => e.ProductIdsaleCost).HasColumnName("Product_IDSaleCost");

        builder.Property(e => e.PurchaseTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Saletax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Serial1)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Serial2)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Serial3)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SrAccount).HasColumnName("Sr_Account");

        builder.Property(e => e.SrReSale).HasColumnName("Sr_ReSale");

        builder.Property(e => e.SrSale).HasColumnName("Sr_Sale");

        builder.Property(e => e.StIdresale).HasColumnName("st_idresale");

        builder.Property(e => e.StIdsale).HasColumnName("st_idsale");

        builder.Property(e => e.StIdsalecost).HasColumnName("st_idsalecost");

        builder.Property(e => e.StIdstock).HasColumnName("st_idstock");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite")
            .HasDefaultValueSql("('')");
    }
}