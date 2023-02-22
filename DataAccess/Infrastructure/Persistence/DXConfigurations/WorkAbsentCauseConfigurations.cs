using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAbsentCauseConfiguration : IEntityTypeConfiguration<WorkAbsentCause>
{


    public void Configure(EntityTypeBuilder<WorkAbsentCause> builder)
    {
        builder.ToTable("work_AbsentCause");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OperatIndex).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}