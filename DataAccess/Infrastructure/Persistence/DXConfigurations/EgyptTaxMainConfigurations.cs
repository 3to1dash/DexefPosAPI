using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EgyptTaxMainConfiguration : IEntityTypeConfiguration<EgyptTaxMain>
{
    public void Configure(EntityTypeBuilder<EgyptTaxMain> builder)
    {
        builder.ToTable("EgyptTaxMain");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescArName).HasMaxLength(250);

        builder.Property(e => e.DescChName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescEnName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescFrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescRoName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescRuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescTuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DescUrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Image).HasMaxLength(50);

        builder.Property(e => e.RoName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}