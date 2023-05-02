using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FactoreItemPriceConfiguration : IEntityTypeConfiguration<FactoreItemPrice>
{
    public void Configure(EntityTypeBuilder<FactoreItemPrice> builder)
    {
        builder.ToTable("Factore_ItemPrice");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StageID");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}