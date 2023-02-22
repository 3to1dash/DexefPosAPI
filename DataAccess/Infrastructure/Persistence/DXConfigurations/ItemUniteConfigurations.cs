using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemUniteConfiguration : IEntityTypeConfiguration<ItemUnite>
{


    public void Configure(EntityTypeBuilder<ItemUnite> builder)
    {
        builder.HasNoKey();

        builder.ToView("ItemUnites");

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy");

        builder.Property(e => e.Calc).HasMaxLength(50);

        builder.Property(e => e.Calc1).HasMaxLength(50);

        builder.Property(e => e.Calc2).HasMaxLength(50);

        builder.Property(e => e.Calc3).HasMaxLength(50);

        builder.Property(e => e.Calc4).HasMaxLength(50);

        builder.Property(e => e.Calc5).HasMaxLength(50);

        builder.Property(e => e.Calc6).HasMaxLength(50);

        builder.Property(e => e.Calc7).HasMaxLength(50);

        builder.Property(e => e.Calc8).HasMaxLength(50);

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Isselect).HasColumnName("ISSelect");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Levels)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("levels");

        builder.Property(e => e.Masterbuy).HasColumnName("masterbuy");

        builder.Property(e => e.Mastersale).HasColumnName("mastersale");

        builder.Property(e => e.MyId)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("MyID");

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

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Quota).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid).HasColumnName("rowguid");

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.VendorCode).HasMaxLength(50);
    }
}