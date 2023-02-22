using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointScenarioConfiguration : IEntityTypeConfiguration<PointScenario>
{


    public void Configure(EntityTypeBuilder<PointScenario> builder)
    {
        builder.ToTable("Point_Scenario");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.FromValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ItemCount).HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Point).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}