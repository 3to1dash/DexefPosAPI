using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BranchCycleEntryConfiguration : IEntityTypeConfiguration<BranchCycleEntry>
{


    public void Configure(EntityTypeBuilder<BranchCycleEntry> builder)
    {
        builder.ToTable("BranchCycle_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Role).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TableName).HasMaxLength(50);
    }
}