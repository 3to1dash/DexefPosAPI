using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaintenanceDeliveryConfiguration : IEntityTypeConfiguration<MaintenanceDelivery>
{


    public void Configure(EntityTypeBuilder<MaintenanceDelivery> builder)
    {
        builder.ToTable("MaintenanceDelivery");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dafter)
            .HasMaxLength(5)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeviceModel).HasMaxLength(50);

        builder.Property(e => e.DeviceSerial).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.ExtraId).HasColumnName("ExtraID");

        builder.Property(e => e.ExtraValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Isguarantee).HasColumnName("ISGuarantee");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MaintenanceId).HasColumnName("MaintenanceID");

        builder.Property(e => e.Note).HasMaxLength(600);

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalPay).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalRemin).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}