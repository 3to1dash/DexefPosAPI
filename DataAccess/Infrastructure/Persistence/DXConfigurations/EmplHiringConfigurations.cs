using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplHiringConfiguration : IEntityTypeConfiguration<EmplHiring>
{
    public void Configure(EntityTypeBuilder<EmplHiring> builder)
    {
        builder.ToTable("Empl_Hiring");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Description).HasMaxLength(600);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.PrevStatus).HasMaxLength(50);

        builder.Property(e => e.Status).HasMaxLength(50);
    }
}