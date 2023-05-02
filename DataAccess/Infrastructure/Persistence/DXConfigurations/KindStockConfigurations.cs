using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindStockConfiguration : IEntityTypeConfiguration<KindStock>
{
    public void Configure(EntityTypeBuilder<KindStock> builder)
    {
        builder.ToTable("kind_stock");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Adress)
            .HasMaxLength(100)
            .HasColumnName("adress");

        builder.Property(e => e.Area)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("area");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Countkind).HasColumnName("countkind");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Mobile1)
            .HasMaxLength(20)
            .HasColumnName("mobile1");

        builder.Property(e => e.Mobile2)
            .HasMaxLength(20)
            .HasColumnName("mobile2");

        builder.Property(e => e.Mobile3)
            .HasMaxLength(20)
            .HasColumnName("mobile3");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Stock)
            .HasMaxLength(50)
            .HasColumnName("stock");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID")
            .HasDefaultValueSql("((0))");
    }
}