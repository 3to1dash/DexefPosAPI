using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrExperienceConfiguration : IEntityTypeConfiguration<HrExperience>
{


    public void Configure(EntityTypeBuilder<HrExperience> builder)
    {
        builder.ToTable("HR_Experience");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Company).HasMaxLength(50);

        builder.Property(e => e.Description).HasMaxLength(50);

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("datetime");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.JobId).HasColumnName("JobID");

        builder.Property(e => e.Note).HasMaxLength(500);
    }
}