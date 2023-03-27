using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepVendorPercConfiguration : IEntityTypeConfiguration<RepVendorPerc>
{
    public void Configure(EntityTypeBuilder<RepVendorPerc> builder)
    {
        builder.ToTable("RepVendorPerc");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.PercAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");

        builder.Property(e => e.TotalAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.VendorAmount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.VendorIds).HasColumnName("VendorIDs");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}