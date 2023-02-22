using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BuyPhotoConfiguration : IEntityTypeConfiguration<BuyPhoto>
{


    public void Configure(EntityTypeBuilder<BuyPhoto> builder)
    {
        builder.HasNoKey();

        builder.ToTable("buy_photo");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Photo)
            .HasColumnType("image")
            .HasColumnName("photo");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}