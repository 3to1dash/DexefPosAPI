using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetRentLongConfiguration : IEntityTypeConfiguration<AssetRentLong>
{
    public void Configure(EntityTypeBuilder<AssetRentLong> builder)
    {
        builder.ToTable("AssetRentLong");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AssetId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AssetID");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtPay).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("datetime");

        builder.Property(e => e.InsuranceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("InsuranceID");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Period).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PrePaid).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("rate");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.RentInsurance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RentType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RentValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TotalPaid).HasColumnType("numeric(19, 5)");
    }
}