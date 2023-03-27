using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripCommissionConfiguration : IEntityTypeConfiguration<TripCommission>
{
    public void Configure(EntityTypeBuilder<TripCommission> builder)
    {
        builder.ToTable("Trip_Commission");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.LastUpdate).HasColumnType("datetime");

        builder.Property(e => e.Minmum).HasColumnType("money");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripCommissions)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_Commission_Company_Branch");
    }
}