using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindSizeConfiguration : IEntityTypeConfiguration<KindSize>
{
    public void Configure(EntityTypeBuilder<KindSize> builder)
    {
        builder.ToTable("kind_Size");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasMaxLength(50);
    }
}