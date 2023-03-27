using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShippingDriverConfiguration : IEntityTypeConfiguration<ShippingDriver>
{
    public void Configure(EntityTypeBuilder<ShippingDriver> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CarId).HasColumnName("CarID");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.LicenseNum).HasMaxLength(50);

        builder.Property(e => e.LicenseType).HasMaxLength(50);

        builder.Property(e => e.Mob1).HasMaxLength(50);

        builder.Property(e => e.Mob2).HasMaxLength(50);

        builder.Property(e => e.Mob3).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}