using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPeriodConfiguration : IEntityTypeConfiguration<WorkPeriod>
{


    public void Configure(EntityTypeBuilder<WorkPeriod> builder)
    {
        builder.ToTable("Work_Period");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.FromTime).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToTime).HasColumnType("datetime");
    }
}