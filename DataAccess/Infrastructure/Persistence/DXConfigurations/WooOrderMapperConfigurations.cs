using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderMapperConfiguration : IEntityTypeConfiguration<WooOrderMapper>
{


    public void Configure(EntityTypeBuilder<WooOrderMapper> builder)
    {
        builder.ToTable("WooOrderMapper");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.OnlineState)
            .HasMaxLength(20)
            .IsFixedLength();

        builder.Property(e => e.TaskId).HasColumnType("numeric(19, 15)");
    }
}