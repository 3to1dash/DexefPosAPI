using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShBoxOpeningConfiguration : IEntityTypeConfiguration<ShBoxOpening>
{
    public void Configure(EntityTypeBuilder<ShBoxOpening> builder)
    {
        builder.ToTable("Sh_BoxOpening");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Balance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Box)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxSum)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CapitalId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CapitalID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("CustID");

        builder.Property(e => e.DiffPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IsBranch).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsStore).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isvendor)
            .HasColumnName("ISVendor")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalBox)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalBoxRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}