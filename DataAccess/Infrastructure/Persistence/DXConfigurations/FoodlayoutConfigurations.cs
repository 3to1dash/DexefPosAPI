using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FoodlayoutConfiguration : IEntityTypeConfiguration<Foodlayout>
{
    public void Configure(EntityTypeBuilder<Foodlayout> builder)
    {
        builder.ToTable("foodlayout");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Color)
            .HasMaxLength(150)
            .HasColumnName("color");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .HasColumnName("detail");

        builder.Property(e => e.Groupid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("groupid");

        builder.Property(e => e.Kind)
            .HasMaxLength(50)
            .HasColumnName("kind");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Locx)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("locx");

        builder.Property(e => e.Locy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("locy");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Reid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("reid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sizex)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sizex");

        builder.Property(e => e.Sizey)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sizey");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");
    }
}