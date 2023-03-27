using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ReportsTileConfiguration : IEntityTypeConfiguration<ReportsTile>
{
    public void Configure(EntityTypeBuilder<ReportsTile> builder)
    {
        builder.ToTable("Reports_Tile");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(255);

        builder.Property(e => e.ArNameDesc).HasMaxLength(255);

        builder.Property(e => e.ChName).HasMaxLength(255);

        builder.Property(e => e.EnName).HasMaxLength(255);

        builder.Property(e => e.FrName).HasMaxLength(255);

        builder.Property(e => e.RoName).HasMaxLength(255);

        builder.Property(e => e.RuName).HasMaxLength(255);

        builder.Property(e => e.TuName).HasMaxLength(255);
    }
}