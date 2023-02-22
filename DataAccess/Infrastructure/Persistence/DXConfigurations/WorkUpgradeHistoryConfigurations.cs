using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkUpgradeHistoryConfiguration : IEntityTypeConfiguration<WorkUpgradeHistory>
{


    public void Configure(EntityTypeBuilder<WorkUpgradeHistory> builder)
    {
        builder.ToTable("Work_upgradeHistory");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.DepartId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DepartID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.JobId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("JobID");

        builder.Property(e => e.Note).HasMaxLength(350);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Salary).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.SliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SliceID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}