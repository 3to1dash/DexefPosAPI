using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class LangConfiguration : IEntityTypeConfiguration<Lang>
{


    public void Configure(EntityTypeBuilder<Lang> builder)
    {
        builder.ToTable("Lang");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Arabic).HasDefaultValueSql("((0))");

        builder.Property(e => e.French).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsMultiLang)
            .HasColumnName("isMultiLang")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}