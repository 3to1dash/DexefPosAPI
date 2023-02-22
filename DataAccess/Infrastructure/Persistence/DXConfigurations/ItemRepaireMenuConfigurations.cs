using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemRepaireMenuConfiguration : IEntityTypeConfiguration<ItemRepaireMenu>
{


    public void Configure(EntityTypeBuilder<ItemRepaireMenu> builder)
    {
        builder.ToTable("item_repaire_menu");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Day)
            .HasColumnName("day")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Hour).HasDefaultValueSql("((0))");

        builder.Property(e => e.Invalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("invalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemGroup).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note)
            .HasMaxLength(250)
            .HasColumnName("note");

        builder.Property(e => e.Outvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("outvalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Period)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("period")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}