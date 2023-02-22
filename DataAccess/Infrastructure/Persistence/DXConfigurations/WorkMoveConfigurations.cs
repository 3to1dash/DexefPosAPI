using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkMoveConfiguration : IEntityTypeConfiguration<WorkMove>
{


    public void Configure(EntityTypeBuilder<WorkMove> builder)
    {
        builder.ToTable("Work_Move");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DepartId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DepartID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.JobId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("JobID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrevBranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PrevBranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrevDepart)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrevJob)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrevSlice)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SLiceID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID")
            .HasDefaultValueSql("((0))");
    }
}