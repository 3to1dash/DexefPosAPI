using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class TripContractGroupConfigurations : IEntityTypeConfiguration<TripContractGroup>
{
    public void Configure(EntityTypeBuilder<TripContractGroup> builder)
    {
        builder.ToTable("Trip_Contract_Groups");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.FrName).HasMaxLength(150);
        builder.Property(e => e.LstUpdate).HasColumnType("datetime");
        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.UpdatedBy).HasMaxLength(50);
        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}