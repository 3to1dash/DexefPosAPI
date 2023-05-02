using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PartnerGroupConfiguration : IEntityTypeConfiguration<PartnerGroup>
{
    public void Configure(EntityTypeBuilder<PartnerGroup> builder)
    {
        builder.ToTable("Partner_Group");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(350)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}