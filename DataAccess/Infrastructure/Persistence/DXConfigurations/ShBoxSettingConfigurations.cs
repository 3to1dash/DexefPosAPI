using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShBoxSettingConfiguration : IEntityTypeConfiguration<ShBoxSetting>
{


    public void Configure(EntityTypeBuilder<ShBoxSetting> builder)
    {
        builder.ToTable("Sh_BoxSetting");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BoxBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxOut)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Buy).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.HalkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("HalkID");

        builder.Property(e => e.IncomeId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.OpenAccount).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.OpenBox)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenDt).HasColumnType("datetime");

        builder.Property(e => e.OpenPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenRegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PercId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PercID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PurchaseID");

        builder.Property(e => e.Rent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sale).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.SaleId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SaleID");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.StorageRentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageRentID");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}