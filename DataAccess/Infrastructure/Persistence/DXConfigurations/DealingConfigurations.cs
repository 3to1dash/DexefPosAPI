using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DealingConfiguration : IEntityTypeConfiguration<Dealing>
{


    public void Configure(EntityTypeBuilder<Dealing> builder)
    {
        builder.ToTable("Dealing");

        builder.Property(e => e.DealingId)
            .HasMaxLength(50)
            .HasColumnName("DealingID");

        builder.Property(e => e.ArName).HasDefaultValueSql("('')");

        builder.Property(e => e.ChName).HasDefaultValueSql("('')");

        builder.Property(e => e.EnName).HasDefaultValueSql("('')");

        builder.Property(e => e.RoName).HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName).HasDefaultValueSql("('')");

        builder.Property(e => e.TuName).HasDefaultValueSql("('')");

        builder.Property(e => e.UrName).HasDefaultValueSql("('')");
    }
}