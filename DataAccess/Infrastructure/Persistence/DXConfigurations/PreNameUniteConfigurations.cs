using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PreNameUniteConfiguration : IEntityTypeConfiguration<PreNameUnite>
{


    public void Configure(EntityTypeBuilder<PreNameUnite> builder)
    {
        builder.ToTable("PreNameUnite");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.Unite1).HasMaxLength(50);

        builder.Property(e => e.Unite2).HasMaxLength(50);

        builder.Property(e => e.Use1).HasDefaultValueSql("((0))");

        builder.Property(e => e.Use2).HasDefaultValueSql("((0))");
    }
}