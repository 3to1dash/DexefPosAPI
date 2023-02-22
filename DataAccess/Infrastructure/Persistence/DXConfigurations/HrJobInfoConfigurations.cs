using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrJobInfoConfiguration : IEntityTypeConfiguration<HrJobInfo>
{


    public void Configure(EntityTypeBuilder<HrJobInfo> builder)
    {
        builder.ToTable("HR_JobInfo");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

        builder.Property(e => e.DivisionId).HasColumnName("DivisionID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}