using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPledgePayConfiguration : IEntityTypeConfiguration<WorkPledgePay>
{
    public void Configure(EntityTypeBuilder<WorkPledgePay> builder)
    {
        builder.ToTable("Work_PledgePay");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId)
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PledgeId).HasColumnName("PledgeID");

        builder.Property(e => e.Prefix).HasMaxLength(20);

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}