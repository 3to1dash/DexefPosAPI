using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResFloorConfiguration : IEntityTypeConfiguration<ResFloor>
{
    public void Configure(EntityTypeBuilder<ResFloor> builder)
    {
        builder.ToTable("ResFloor");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Notes).HasMaxLength(500);
    }
}