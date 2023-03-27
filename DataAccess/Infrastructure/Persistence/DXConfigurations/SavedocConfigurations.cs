using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SavedocConfiguration : IEntityTypeConfiguration<Savedoc>
{
    public void Configure(EntityTypeBuilder<Savedoc> builder)
    {
        builder.HasNoKey();

        builder.ToTable("savedoc");

        builder.Property(e => e.Cmpnum)
            .HasMaxLength(50)
            .HasColumnName("cmpnum")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Path).HasColumnName("path");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");
    }
}