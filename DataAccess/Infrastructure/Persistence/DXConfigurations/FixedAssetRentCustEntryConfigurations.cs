using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetRentCustEntryConfiguration : IEntityTypeConfiguration<FixedAssetRentCustEntry>
{


    public void Configure(EntityTypeBuilder<FixedAssetRentCustEntry> builder)
    {
        builder.HasNoKey();

        builder.ToTable("FixedAssetRentCustEntry");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Insurance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MethodId).HasColumnName("MethodID");

        builder.Property(e => e.Notes).HasMaxLength(250);

        builder.Property(e => e.OtherInsurancesId).HasColumnName("OtherInsurancesID");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RentAccountId).HasColumnName("RentAccountID");

        builder.Property(e => e.RentPeriod).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalInsurance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}