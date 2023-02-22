using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShBranchDailyActionConfiguration : IEntityTypeConfiguration<ShBranchDailyAction>
{


    public void Configure(EntityTypeBuilder<ShBranchDailyAction> builder)
    {
        builder.ToTable("sh_BranchDailyAction");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BoxIn)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BoxIN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxOut)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BoxOUT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Cust)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MsgSpent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Recieve)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sales)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.Spent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Vendor)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}