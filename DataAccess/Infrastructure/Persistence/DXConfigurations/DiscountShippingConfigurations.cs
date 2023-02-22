using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountShippingConfiguration : IEntityTypeConfiguration<DiscountShipping>
{


    public void Configure(EntityTypeBuilder<DiscountShipping> builder)
    {
        builder.ToTable("DiscountShipping");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ButtonImage).HasMaxLength(50);

        builder.Property(e => e.CalcType).HasMaxLength(50);

        builder.Property(e => e.Editable).HasDefaultValueSql("((0))");

        builder.Property(e => e.Img).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(18, 5)");
    }
}