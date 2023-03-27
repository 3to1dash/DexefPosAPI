using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyCashPaidConfiguration : IEntityTypeConfiguration<DailyCashPaid>
{
    public void Configure(EntityTypeBuilder<DailyCashPaid> builder)
    {
        builder.ToTable("DailyCashPaid");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.DueDt)
            .HasColumnType("datetime")
            .HasColumnName("DueDT");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Paid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidDt).HasColumnType("datetime");

        builder.Property(e => e.PaidNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaidUser).HasMaxLength(50);

        builder.Property(e => e.ReferId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ReferID");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}