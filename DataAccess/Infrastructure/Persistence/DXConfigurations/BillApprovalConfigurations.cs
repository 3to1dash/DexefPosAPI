using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillApprovalConfiguration : IEntityTypeConfiguration<BillApproval>
{


    public void Configure(EntityTypeBuilder<BillApproval> builder)
    {
        builder.ToTable("Bill_Approvals");

        builder.HasIndex(e => new { e.TaskId, e.Dealing, e.WrittenBy, e.Answer, e.BranchId }, "NonClusteredIndex-20200311-134700");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AnswerDt)
            .HasColumnType("datetime")
            .HasColumnName("AnswerDT");

        builder.Property(e => e.AnswerUser).HasMaxLength(50);

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Comment).HasMaxLength(750);

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.TargetUser).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}