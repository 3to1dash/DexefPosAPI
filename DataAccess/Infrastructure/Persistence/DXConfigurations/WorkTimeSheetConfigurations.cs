using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkTimeSheetConfiguration : IEntityTypeConfiguration<WorkTimeSheet>
{


    public void Configure(EntityTypeBuilder<WorkTimeSheet> builder)
    {
        builder.ToTable("Work_TimeSheet");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AddedHours)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CheckIn).HasDefaultValueSql("((0))");

        builder.Property(e => e.CheckInTime).HasColumnType("datetime");

        builder.Property(e => e.CheckOut).HasDefaultValueSql("((0))");

        builder.Property(e => e.CheckOutTime).HasColumnType("datetime");

        builder.Property(e => e.DedcutedHours)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("date")
            .HasColumnName("DT");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");

        builder.Property(e => e.TimeOffType).HasMaxLength(50);
    }
}