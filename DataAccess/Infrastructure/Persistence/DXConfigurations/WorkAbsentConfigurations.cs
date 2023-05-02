using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAbsentConfiguration : IEntityTypeConfiguration<WorkAbsent>
{
    public void Configure(EntityTypeBuilder<WorkAbsent> builder)
    {
        builder.ToTable("Work_Absent");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Closed).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(50)
            .HasColumnName("DTHijri");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OperatIndex)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");

        builder.Property(e => e.Workid).HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}