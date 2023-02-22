using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPledgeReceiveConfiguration : IEntityTypeConfiguration<WorkPledgeReceive>
{


    public void Configure(EntityTypeBuilder<WorkPledgeReceive> builder)
    {
        builder.ToTable("Work_PledgeReceive");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CashType).HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum).HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StorageId).HasColumnName("StorageID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Workid)
            .HasColumnName("workid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}