using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindPriceEquationConfiguration : IEntityTypeConfiguration<KindPriceEquation>
{


    public void Configure(EntityTypeBuilder<KindPriceEquation> builder)
    {
        builder.ToTable("Kind_PriceEquation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UsedEquation)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(e => e.UsedPrice)
            .HasMaxLength(20)
            .IsUnicode(false);
    }
}