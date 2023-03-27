using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAttendanceInOutConfiguration : IEntityTypeConfiguration<WorkAttendanceInOut>
{
    public void Configure(EntityTypeBuilder<WorkAttendanceInOut> builder)
    {
        builder.ToTable("Work_Attendance_InOut");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.LogTime).HasColumnType("datetime");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeOffType).HasMaxLength(50);

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}