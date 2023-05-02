using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPeriodEntryConfiguration : IEntityTypeConfiguration<WorkPeriodEntry>
{
    public void Configure(EntityTypeBuilder<WorkPeriodEntry> builder)
    {
        builder.ToTable("Work_PeriodEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.IsWork).HasMaxLength(50);

        builder.Property(e => e.LogIn).HasColumnType("datetime");

        builder.Property(e => e.LogOut).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}