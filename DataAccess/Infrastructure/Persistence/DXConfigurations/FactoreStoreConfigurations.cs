using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FactoreStoreConfiguration : IEntityTypeConfiguration<FactoreStore>
{
    public void Configure(EntityTypeBuilder<FactoreStore> builder)
    {
        builder.ToTable("Factore_Store");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BeginQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BeginVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.GroupId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("GroupID");

        builder.Property(e => e.InVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Inqty)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("INQty")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.OutQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OutVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StageID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}