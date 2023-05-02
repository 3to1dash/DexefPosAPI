using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateDealingConfiguration : IEntityTypeConfiguration<EstimateDealing>
{
    public void Configure(EntityTypeBuilder<EstimateDealing> builder)
    {
        builder.ToTable("Estimate_dealing");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Costid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EstimateId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("EstimateID");

        builder.Property(e => e.Isship).HasColumnName("ISShip");

        builder.Property(e => e.Note).HasMaxLength(150);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(150)
            .HasColumnName("ship");

        builder.Property(e => e.ShipId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ShipID");

        builder.Property(e => e.SpentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SpentID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}