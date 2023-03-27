using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PreGridEquationConfiguration : IEntityTypeConfiguration<PreGridEquation>
{
    public void Configure(EntityTypeBuilder<PreGridEquation> builder)
    {
        builder.ToTable("PreGridEquation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CanEdit).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasMaxLength(50);
    }
}