using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FoodMealConfiguration : IEntityTypeConfiguration<FoodMeal>
{
    public void Configure(EntityTypeBuilder<FoodMeal> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Food_Meal");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Parentid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("parentid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}