using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindOrderConfiguration : IEntityTypeConfiguration<KindOrder>
{


    public void Configure(EntityTypeBuilder<KindOrder> builder)
    {
        builder.ToTable("Kind_Order");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.Cpu).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}