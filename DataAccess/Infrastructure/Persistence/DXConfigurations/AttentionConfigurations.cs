using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AttentionConfiguration : IEntityTypeConfiguration<Attention>
{


    public void Configure(EntityTypeBuilder<Attention> builder)
    {
        builder.ToTable("Attention");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Detail).HasColumnName("detail");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Subject)
            .HasMaxLength(250)
            .HasColumnName("subject");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}