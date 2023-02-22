using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RKitchenConfiguration : IEntityTypeConfiguration<RKitchen>
{


    public void Configure(EntityTypeBuilder<RKitchen> builder)
    {
        builder.ToTable("R_Kitchen");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Cpu).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TableId).HasColumnName("TableID");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}