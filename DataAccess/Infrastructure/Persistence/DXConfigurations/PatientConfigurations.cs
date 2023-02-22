using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{


    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(400);

        builder.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

        builder.Property(e => e.Mail).HasMaxLength(150);

        builder.Property(e => e.Mob1).HasMaxLength(50);

        builder.Property(e => e.Mob2).HasMaxLength(50);

        builder.Property(e => e.Mob3).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.PercentId).HasColumnName("PercentID");
    }
}