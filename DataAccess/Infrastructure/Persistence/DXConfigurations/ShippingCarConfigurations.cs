using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShippingCarConfiguration : IEntityTypeConfiguration<ShippingCar>
{
    public void Configure(EntityTypeBuilder<ShippingCar> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CarType).HasMaxLength(150);

        builder.Property(e => e.ChasesaNum).HasMaxLength(150);

        builder.Property(e => e.FuelId).HasColumnName("FuelID");

        builder.Property(e => e.LicenseDt).HasColumnType("datetime");

        builder.Property(e => e.LicenseDtEnd).HasColumnType("datetime");

        builder.Property(e => e.LicenseNum).HasMaxLength(150);

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Model).HasMaxLength(150);

        builder.Property(e => e.MotorNum).HasMaxLength(150);

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}