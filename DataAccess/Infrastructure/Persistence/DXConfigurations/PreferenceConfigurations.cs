using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PreferenceConfiguration : IEntityTypeConfiguration<Preference>
{
    public void Configure(EntityTypeBuilder<Preference> builder)
    {
        builder.ToTable("Preference");

        builder.HasOne(d => d.DefaultFilterPeriod)
            .WithMany(p => p.Preferences)
            .HasForeignKey(d => d.DefaultFilterPeriodId)
            .HasConstraintName("FK_Preference_DefaultFilterPeriod");

        builder.HasOne(d => d.Language)
            .WithMany(p => p.Preferences)
            .HasForeignKey(d => d.LanguageId)
            .HasConstraintName("FK_Preferences_Language");
    }
}