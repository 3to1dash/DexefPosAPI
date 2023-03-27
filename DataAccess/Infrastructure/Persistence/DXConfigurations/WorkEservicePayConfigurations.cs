using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkEservicePayConfiguration : IEntityTypeConfiguration<WorkEservicePay>
{
    public void Configure(EntityTypeBuilder<WorkEservicePay> builder)
    {
        builder.ToTable("Work_EServicePay");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Closed).HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.PaidCo)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidCoId)
            .HasColumnName("PaidCoID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidWork)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidWorkId)
            .HasColumnName("PaidWorkID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayId).HasColumnName("PayID");

        builder.Property(e => e.PayTime).HasDefaultValueSql("((0))");

        builder.Property(e => e.PercCo)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PercWork)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ServiceId).HasColumnName("ServiceID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WorkId).HasColumnName("WorkID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}