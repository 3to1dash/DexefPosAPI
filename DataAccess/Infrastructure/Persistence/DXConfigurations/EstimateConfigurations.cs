using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateConfiguration : IEntityTypeConfiguration<Estimate>
{


    public void Configure(EntityTypeBuilder<Estimate> builder)
    {
        builder.ToTable("Estimate");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.ComisionPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ComisionValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CoverPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CoverValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.DtClose).HasColumnType("datetime");

        builder.Property(e => e.DtOpen).HasColumnType("datetime");

        builder.Property(e => e.LocalAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(250);

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Prefex).HasMaxLength(50);

        builder.Property(e => e.PurchaseOrder).HasMaxLength(50);

        builder.Property(e => e.PurchaseOrderValue).HasColumnType("numeric(19, 15)");

        builder.Property(e => e.Rate).HasColumnType("decimal(18, 5)");

        builder.Property(e => e.ShipManner).HasMaxLength(50);

        builder.Property(e => e.ShipType).HasMaxLength(50);

        builder.Property(e => e.ShippingDt)
            .HasColumnType("datetime")
            .HasColumnName("ShippingDT");

        builder.Property(e => e.ShippingPort).HasMaxLength(250);

        builder.Property(e => e.ShippingWay).HasMaxLength(50);

        builder.Property(e => e.Status).HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdateBy).HasMaxLength(150);

        builder.Property(e => e.VendorBank).HasMaxLength(150);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}