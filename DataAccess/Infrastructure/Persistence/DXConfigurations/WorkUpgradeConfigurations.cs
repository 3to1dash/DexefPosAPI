using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkUpgradeConfiguration : IEntityTypeConfiguration<WorkUpgrade>
{
    public void Configure(EntityTypeBuilder<WorkUpgrade> builder)
    {
        builder.ToTable("Work_Upgrade");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.DepartId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DepartID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.JobId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("JobID");

        builder.Property(e => e.NewBranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("NewBranchID");

        builder.Property(e => e.Note).HasMaxLength(350);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.OldDepartId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OldDepartID");

        builder.Property(e => e.OldJobId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OldJobID");

        builder.Property(e => e.OldSliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OldSLiceID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

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