using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrProctionPercEntryConfiguration : IEntityTypeConfiguration<HrProctionPercEntry>
{


    public void Configure(EntityTypeBuilder<HrProctionPercEntry> builder)
    {
        builder.ToTable("Hr_ProctionPerc_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .HasColumnName("code");

        builder.Property(e => e.Cost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.ProductionId).HasColumnName("ProductionID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}