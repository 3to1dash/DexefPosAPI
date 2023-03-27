using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillHistoryConfiguration : IEntityTypeConfiguration<BillHistory>
{
    public void Configure(EntityTypeBuilder<BillHistory> builder)
    {
        builder.ToTable("Bill_History");

        builder.HasIndex(e => e.TransactionType, "IX_Bill_History_TransactionType_F61CE");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.NetTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TargetBillNum).HasMaxLength(50);

        builder.Property(e => e.TargetDealing).HasMaxLength(50);

        builder.Property(e => e.TargetTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TargetTaskID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TransactionType).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}