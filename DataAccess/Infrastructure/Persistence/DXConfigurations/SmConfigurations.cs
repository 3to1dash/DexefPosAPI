using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmConfiguration : IEntityTypeConfiguration<Sm>
{
    public void Configure(EntityTypeBuilder<Sm> builder)
    {
        builder.ToTable("SMS");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Api).HasColumnName("API");

        builder.Property(e => e.Apibalance)
            .HasMaxLength(500)
            .HasColumnName("APIBalance");

        builder.Property(e => e.Issdk)
            .HasColumnName("ISSDK")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Password).HasMaxLength(250);

        builder.Property(e => e.SuccessfullyCode).HasMaxLength(50);

        builder.Property(e => e.UserName).HasMaxLength(250);
    }
}