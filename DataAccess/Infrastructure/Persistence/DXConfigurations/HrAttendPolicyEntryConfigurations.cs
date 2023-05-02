using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrAttendPolicyEntryConfiguration : IEntityTypeConfiguration<HrAttendPolicyEntry>
{
    public void Configure(EntityTypeBuilder<HrAttendPolicyEntry> builder)
    {
        builder.ToTable("Hr_AttendPolicy_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.PolicyId).HasColumnName("PolicyID");

        builder.Property(e => e.WorkShiftId).HasColumnName("WorkShiftID");
    }
}