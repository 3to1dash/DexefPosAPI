using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSkillConfiguration : IEntityTypeConfiguration<EmplSkill>
{
    public void Configure(EntityTypeBuilder<EmplSkill> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Empl_Skills");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.SkillId).HasColumnName("SkillID");
    }
}