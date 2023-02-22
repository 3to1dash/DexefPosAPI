using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetRentConfiguration : IEntityTypeConfiguration<AssetRent>
{


    public void Configure(EntityTypeBuilder<AssetRent> builder)
    {
        builder.ToTable("AssetRent");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("accountid");

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Counts).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Fromdt)
            .HasColumnType("datetime")
            .HasColumnName("fromdt");

        builder.Property(e => e.Fromtime)
            .HasColumnType("datetime")
            .HasColumnName("fromtime");

        builder.Property(e => e.Insurance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.InsuranceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("InsuranceID");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PrePaid).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("remain")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.Todt)
            .HasColumnType("datetime")
            .HasColumnName("todt");

        builder.Property(e => e.Total).HasColumnType("money");

        builder.Property(e => e.Totime)
            .HasColumnType("datetime")
            .HasColumnName("totime");

        builder.Property(e => e.WorkRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}