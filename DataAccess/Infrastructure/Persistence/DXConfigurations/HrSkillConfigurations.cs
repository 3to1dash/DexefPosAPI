using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrSkillConfiguration : IEntityTypeConfiguration<HrSkill>
{


    public void Configure(EntityTypeBuilder<HrSkill> builder)
    {
        builder.ToTable("HR_Skills");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.SkillId).HasColumnName("SkillID");
    }
}