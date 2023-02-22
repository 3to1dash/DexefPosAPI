using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AreaLinkConfiguration : IEntityTypeConfiguration<AreaLink>
{


    public void Configure(EntityTypeBuilder<AreaLink> builder)
    {
        builder.ToTable("Area_Link");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AreaId)
            .HasColumnName("AreaID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AreaType).HasMaxLength(50);

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");
    }
}