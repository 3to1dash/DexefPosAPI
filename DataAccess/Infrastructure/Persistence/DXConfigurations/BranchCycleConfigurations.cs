using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BranchCycleConfiguration : IEntityTypeConfiguration<BranchCycle>
{


    public void Configure(EntityTypeBuilder<BranchCycle> builder)
    {
        builder.ToTable("BranchCycle");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.PurchaseCycle).HasMaxLength(5);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCycle).HasMaxLength(5);

        builder.Property(e => e.StoreCycle).HasMaxLength(5);
    }
}