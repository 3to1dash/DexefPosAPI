using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CostCenterEntryConfiguration : IEntityTypeConfiguration<CostCenterEntry>
{
    public void Configure(EntityTypeBuilder<CostCenterEntry> builder)
    {
        builder.ToTable("CostCenter_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CalcWay).HasMaxLength(50);

        builder.Property(e => e.Perc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}