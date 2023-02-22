using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RpsItemConfiguration : IEntityTypeConfiguration<RpsItem>
{


    public void Configure(EntityTypeBuilder<RpsItem> builder)
    {
        builder.HasNoKey();

        builder.ToView("RpsItem");

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindGroup).HasColumnName("kind_group");

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

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale");

        builder.Property(e => e.StoreId).HasColumnName("storeID");

        builder.Property(e => e.Totalval).HasColumnType("numeric(19, 5)");

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
    }
}