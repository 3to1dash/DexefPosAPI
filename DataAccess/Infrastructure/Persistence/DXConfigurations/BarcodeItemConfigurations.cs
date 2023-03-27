using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BarcodeItemConfiguration : IEntityTypeConfiguration<BarcodeItem>
{
    public void Configure(EntityTypeBuilder<BarcodeItem> builder)
    {
        builder.ToTable("Barcode_item");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.ExpireBarcode)
            .HasMaxLength(50)
            .HasColumnName("Expire_Barcode");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.Operate).HasMaxLength(50);

        builder.Property(e => e.Price).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.VendorCode).HasMaxLength(50);
    }
}