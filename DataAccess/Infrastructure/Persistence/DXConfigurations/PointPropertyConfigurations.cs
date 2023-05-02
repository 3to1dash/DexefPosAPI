using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointPropertyConfiguration : IEntityTypeConfiguration<PointProperty>
{
    public void Configure(EntityTypeBuilder<PointProperty> builder)
    {
        builder.ToTable("Point_Properties");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Counts).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CreateCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DestroyPoint).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Expire).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ExpireNotUse).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Minimum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReActivePoint).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}