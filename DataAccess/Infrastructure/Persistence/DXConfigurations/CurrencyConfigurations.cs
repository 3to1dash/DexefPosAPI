using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.ToTable("currency");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.AutoUpdate).HasDefaultValueSql("((0))");

        builder.Property(e => e.AvgPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BuyOldVal)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BuyRate)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsLocal).HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCurrency).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.PurchaseId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PurchaseID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SaleID");

        builder.Property(e => e.SaleOldVal)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.SaleRate)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Shortcut).HasMaxLength(50);

        builder.Property(e => e.SubOne).HasDefaultValueSql("((0))");

        builder.Property(e => e.Transfer).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(38, 12)")
            .HasColumnName("value");
    }
}