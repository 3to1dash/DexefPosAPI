using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindDrugConfiguration : IEntityTypeConfiguration<KindDrug>
{


    public void Configure(EntityTypeBuilder<KindDrug> builder)
    {
        builder.ToTable("Kind_Drugs");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DistributionArea).HasMaxLength(50);

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.RegisterNumber).HasMaxLength(50);

        builder.Property(e => e.RegisterYear)
            .HasMaxLength(50)
            .HasColumnName("registerYear");

        builder.Property(e => e.StorageConditionId).HasColumnName("StorageConditionID");

        builder.Property(e => e.Strength).HasMaxLength(50);

        builder.Property(e => e.StrengthUnit).HasMaxLength(50);
    }
}