using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CTenderDatumConfiguration : IEntityTypeConfiguration<CTenderDatum>
{
    public void Configure(EntityTypeBuilder<CTenderDatum> builder)
    {
        builder.ToTable("C_TenderData");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Detial).HasDefaultValueSql("('')");

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("datetime");

        builder.Property(e => e.Groups)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ImageIndex)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsGroup).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsSubContract).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemPreTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemUnite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Note)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.OrderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OrderID");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PreTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Profit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ProfitPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.State)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TenderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TenderID");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}