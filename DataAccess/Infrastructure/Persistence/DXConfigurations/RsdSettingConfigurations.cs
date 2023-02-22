using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RsdSettingConfiguration : IEntityTypeConfiguration<RsdSetting>
{


    public void Configure(EntityTypeBuilder<RsdSetting> builder)
    {
        builder.ToTable("RSD_Setting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.PrescriptionDt).HasColumnName("PrescriptionDT");

        builder.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");

        builder.Property(e => e.UserId).HasColumnName("UserID");
    }
}