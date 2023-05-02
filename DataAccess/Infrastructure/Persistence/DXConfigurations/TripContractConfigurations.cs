using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripContractConfiguration : IEntityTypeConfiguration<TripContract>
{
    public void Configure(EntityTypeBuilder<TripContract> builder)
    {
        builder.ToTable("Trip_Contract");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CommissionIncludeTaxes).HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TripAirLineCommissionId).HasColumnName("Trip_AirLineCommissionId");

        builder.Property(e => e.TripCommissionId).HasColumnName("Trip_CommissionId");

        builder.Property(e => e.TripGdsid).HasColumnName("Trip_GDSId");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripContracts)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_Contract_Company_Branch");

        builder.HasOne(d => d.Cust)
            .WithMany(p => p.TripContracts)
            .HasForeignKey(d => d.CustId)
            .HasConstraintName("FK_Trip_Contract_Cust");

        builder.HasOne(d => d.TripCommission)
            .WithMany(p => p.TripContracts)
            .HasForeignKey(d => d.TripCommissionId)
            .HasConstraintName("FK_Trip_Contract_Trip_Commission");

        builder.HasOne(d => d.TripGds)
            .WithMany(p => p.TripContracts)
            .HasForeignKey(d => d.TripGdsid)
            .HasConstraintName("FK_Trip_Contract_Trip_GDS");
    }
}