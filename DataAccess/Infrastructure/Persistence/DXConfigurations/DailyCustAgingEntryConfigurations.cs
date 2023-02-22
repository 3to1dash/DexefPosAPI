using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyCustAgingEntryConfiguration : IEntityTypeConfiguration<DailyCustAgingEntry>
{


    public void Configure(EntityTypeBuilder<DailyCustAgingEntry> builder)
    {
        builder.ToTable("DailyCustAging_Entry");

        builder.HasIndex(e => e.ParentTaskId, "IX_DailyCustAging_Entry_ParentTaskID_71456");

        builder.HasIndex(e => new { e.ParentTaskId, e.TaskId }, "IX_DailyCustAging_Entry_ParentTaskID_TaskID_4E6A8");

        builder.HasIndex(e => new { e.ParentTaskId, e.TaskId, e.InstallmentId }, "IX_DailyCustAging_Entry_ParentTaskID_TaskID_InstallmentID_9BC35");

        builder.HasIndex(e => e.TaskId, "IX_DailyCustAging_Entry_TaskID_A4D36");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustomerAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.IsDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.ParentDealing).HasMaxLength(50);

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SourceAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SourceCurrency).HasMaxLength(50);

        builder.Property(e => e.SourcePaymentName).HasMaxLength(50);

        builder.Property(e => e.SourceRate).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SourceValue)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TargetAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TargetCurrency).HasMaxLength(50);

        builder.Property(e => e.TargetTransferRate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TargetValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}