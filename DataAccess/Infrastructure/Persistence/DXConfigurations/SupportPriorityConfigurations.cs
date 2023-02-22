using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportPriorityConfiguration : IEntityTypeConfiguration<SupportPriority>
{


    public void Configure(EntityTypeBuilder<SupportPriority> builder)
    {
        builder.ToTable("Support_Priority");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Color).HasMaxLength(50);

        builder.Property(e => e.Description).HasMaxLength(550);

        builder.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}