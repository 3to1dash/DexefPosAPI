using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencyRateConfiguration : IEntityTypeConfiguration<CurrencyRate>
{


    public void Configure(EntityTypeBuilder<CurrencyRate> builder)
    {
        builder.ToTable("Currency_Rate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BuyRate)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CurrencyId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CurrencyID");

        builder.Property(e => e.ReferCurrencyId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleRate)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");
    }
}