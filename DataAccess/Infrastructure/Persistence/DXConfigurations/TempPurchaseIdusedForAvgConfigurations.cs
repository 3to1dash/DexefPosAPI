using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempPurchaseIdusedForAvgConfiguration : IEntityTypeConfiguration<TempPurchaseIdusedForAvg>
{


    public void Configure(EntityTypeBuilder<TempPurchaseIdusedForAvg> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_PurchaseIDUsedForAVG");

        builder.Property(e => e.Cat)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");
    }
}