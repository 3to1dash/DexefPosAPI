using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemAdjustmentConfiguration : IEntityTypeConfiguration<ItemAdjustment>
{
    public void Configure(EntityTypeBuilder<ItemAdjustment> builder)
    {
        builder.ToTable("ItemAdjustment");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("accountid");

        builder.Property(e => e.Diffqty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("diffqty");

        builder.Property(e => e.Diffval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("diffval");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Exprdt)
            .HasColumnType("datetime")
            .HasColumnName("exprdt");

        builder.Property(e => e.Itemcost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("itemcost");

        builder.Property(e => e.Itemid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("itemid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Length)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("length");

        builder.Property(e => e.Newqty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("newqty");

        builder.Property(e => e.Newval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("newval");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Nowqty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("nowqty");

        builder.Property(e => e.Nowval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("nowval");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowcost)
            .HasMaxLength(4000)
            .HasColumnName("rowcost");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Serial)
            .HasMaxLength(4000)
            .HasColumnName("serial");

        builder.Property(e => e.Stock)
            .HasMaxLength(50)
            .HasColumnName("stock")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.UniteCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Weight)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("weight");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}