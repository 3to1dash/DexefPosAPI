using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FoodtempConfiguration : IEntityTypeConfiguration<Foodtemp>
{


    public void Configure(EntityTypeBuilder<Foodtemp> builder)
    {
        builder.ToTable("foodtemp");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Kind)
            .HasMaxLength(50)
            .HasColumnName("kind");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.Valunite)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valunite");
    }
}