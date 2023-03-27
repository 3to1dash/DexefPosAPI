using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RpsItemIndexConfiguration : IEntityTypeConfiguration<RpsItemIndex>
{
    public void Configure(EntityTypeBuilder<RpsItemIndex> builder)
    {
        builder.HasNoKey();

        builder.ToView("RpsItemIndex");

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TotalVal).HasColumnType("numeric(19, 5)");

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

        builder.Property(e => e.VendorId).HasColumnName("VendorID");
    }
}