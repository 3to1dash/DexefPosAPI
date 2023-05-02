using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPeriodChangeConfiguration : IEntityTypeConfiguration<WorkPeriodChange>
{
    public void Configure(EntityTypeBuilder<WorkPeriodChange> builder)
    {
        builder.ToTable("Work_PeriodChange");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ChangeVal).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.GroupId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("GroupID");

        builder.Property(e => e.LastTime).HasColumnType("date");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}