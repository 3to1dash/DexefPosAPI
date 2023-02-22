using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountTradePermissionConfiguration : IEntityTypeConfiguration<DiscountTradePermission>
{


    public void Configure(EntityTypeBuilder<DiscountTradePermission> builder)
    {
        builder.ToTable("DiscountTrade_Permission");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}