using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindFreeConfiguration : IEntityTypeConfiguration<KindFree>
{
    public void Configure(EntityTypeBuilder<KindFree> builder)
    {
        builder.ToTable("Kind_Free");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.FreeKindId).HasColumnName("FreeKindID");

        builder.Property(e => e.FreeQty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.FreeUnite).HasMaxLength(50);

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Qty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}