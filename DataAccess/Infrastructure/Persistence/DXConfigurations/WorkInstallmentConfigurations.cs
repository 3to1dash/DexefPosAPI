using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkInstallmentConfiguration : IEntityTypeConfiguration<WorkInstallment>
{
    public void Configure(EntityTypeBuilder<WorkInstallment> builder)
    {
        builder.ToTable("Work_installments");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.BranchId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Counts)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("counts")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Monthly)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("monthly")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note)
            .HasMaxLength(250)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OperatIndex)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("paid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PercValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Profit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Remain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.StartMonth).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.Store).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}