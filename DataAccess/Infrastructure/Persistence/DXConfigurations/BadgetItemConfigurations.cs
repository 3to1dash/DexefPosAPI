using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetItemConfiguration : IEntityTypeConfiguration<BadgetItem>
{
    public void Configure(EntityTypeBuilder<BadgetItem> builder)
    {
        builder.ToTable("Badget_Items");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BadgetId).HasColumnName("BadgetID");

        builder.Property(e => e.Issale).HasColumnName("ISSale");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");
    }
}