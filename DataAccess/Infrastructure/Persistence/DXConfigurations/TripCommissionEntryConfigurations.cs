using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripCommissionEntryConfiguration : IEntityTypeConfiguration<TripCommissionEntry>
{
    public void Configure(EntityTypeBuilder<TripCommissionEntry> builder)
    {
        builder.ToTable("Trip_CommissionEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("money");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Destination).HasMaxLength(5);

        builder.Property(e => e.IsChd)
            .HasColumnName("IsCHD")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.IsaddCom)
            .HasMaxLength(5)
            .IsUnicode(false)
            .HasColumnName("ISAddCom");

        builder.Property(e => e.Perc).HasColumnType("money");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TripCommissionId).HasColumnName("Trip_CommissionId");

        builder.Property(e => e.TripType).HasMaxLength(5);

        builder.HasOne(d => d.TripCommission)
            .WithMany(p => p.TripCommissionEntries)
            .HasForeignKey(d => d.TripCommissionId)
            .HasConstraintName("FK_Trip_CommissionEntry_Trip_Commission");
    }
}