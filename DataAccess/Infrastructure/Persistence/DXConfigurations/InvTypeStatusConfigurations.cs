using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InvTypeStatusConfiguration : IEntityTypeConfiguration<InvTypeStatus>
{
    public void Configure(EntityTypeBuilder<InvTypeStatus> builder)
    {
        builder.ToTable("InvType_Status", "Inv");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DealingId)
            .HasMaxLength(50)
            .HasColumnName("DealingID");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}