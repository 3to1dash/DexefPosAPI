using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShippingCarUsageConfiguration : IEntityTypeConfiguration<ShippingCarUsage>
{
    public void Configure(EntityTypeBuilder<ShippingCarUsage> builder)
    {
        builder.ToTable("ShippingCar_Usage");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CarId).HasColumnName("CarID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("date");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.EdDate)
            .HasColumnType("datetime")
            .HasColumnName("Ed_Date");

        builder.Property(e => e.MileEnd).HasMaxLength(150);

        builder.Property(e => e.MileStart).HasMaxLength(150);

        builder.Property(e => e.Notes)
            .HasMaxLength(350)
            .HasColumnName("notes");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StDt)
            .HasColumnType("datetime")
            .HasColumnName("St_Dt");

        builder.Property(e => e.TotalMiles).HasMaxLength(150);
    }
}