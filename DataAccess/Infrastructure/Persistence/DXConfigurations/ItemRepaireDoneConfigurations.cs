using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemRepaireDoneConfiguration : IEntityTypeConfiguration<ItemRepaireDone>
{
    public void Configure(EntityTypeBuilder<ItemRepaireDone> builder)
    {
        builder.ToTable("item_repaire_done");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Cost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.HasItems).HasDefaultValueSql("((0))");

        builder.Property(e => e.Itemcost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("itemcost")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Itemid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("itemid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Percval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("percval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Refused).HasDefaultValueSql("((0))");

        builder.Property(e => e.Repaired).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Warranty).HasDefaultValueSql("((0))");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}