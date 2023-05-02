using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TranslateConfiguration : IEntityTypeConfiguration<Translate>
{
    public void Configure(EntityTypeBuilder<Translate> builder)
    {
        builder.ToTable("Translate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Arabic).HasMaxLength(50);

        builder.Property(e => e.English).HasMaxLength(50);

        builder.Property(e => e.Frensh).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}