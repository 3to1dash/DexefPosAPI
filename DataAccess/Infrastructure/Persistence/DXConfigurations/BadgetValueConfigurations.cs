using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetValueConfiguration : IEntityTypeConfiguration<BadgetValue>
{
    public void Configure(EntityTypeBuilder<BadgetValue> builder)
    {
        builder.ToTable("Badget_Values");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BadgetId).HasColumnName("BadgetID");

        builder.Property(e => e.BadgetItemId).HasColumnName("BadgetItemID");
    }
}