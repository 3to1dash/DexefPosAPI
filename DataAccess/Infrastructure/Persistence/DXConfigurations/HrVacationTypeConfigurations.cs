using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrVacationTypeConfiguration : IEntityTypeConfiguration<HrVacationType>
{


    public void Configure(EntityTypeBuilder<HrVacationType> builder)
    {
        builder.ToTable("Hr_VacationType");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(250);

        builder.Property(e => e.Balance).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CalcType).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RoName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");
    }
}