using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxesSubGroupConfiguration : IEntityTypeConfiguration<TaxesSubGroup>
{


    public void Configure(EntityTypeBuilder<TaxesSubGroup> builder)
    {
        builder.HasKey(e => e.Code);

        builder.ToTable("Taxes_SubGroup");

        builder.Property(e => e.Code)
            .HasMaxLength(10)
            .IsUnicode(false);

        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.ParentCode)
            .HasMaxLength(10)
            .IsUnicode(false);

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.HasOne(d => d.ParentCodeNavigation)
            .WithMany(p => p.TaxesSubGroups)
            .HasForeignKey(d => d.ParentCode)
            .HasConstraintName("FK_Taxes_SubGroup_Taxes_Group");
    }
}