using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripAirLineCommissionConfiguration : IEntityTypeConfiguration<TripAirLineCommission>
{
    public void Configure(EntityTypeBuilder<TripAirLineCommission> builder)
    {
        builder.ToTable("Trip_AirLineCommission");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.Amount).HasColumnType("decimal(18, 5)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(50);

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripAirLineCommissions)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_AirLineCommission_Company_Branch");
    }
}