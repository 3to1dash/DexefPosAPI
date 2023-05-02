using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DbversionConfiguration : IEntityTypeConfiguration<Dbversion>
{
    public void Configure(EntityTypeBuilder<Dbversion> builder)
    {
        builder.HasKey(e => e.CurrentVer);

        builder.ToTable("DBVersion");

        builder.Property(e => e.CurrentVer).HasColumnType("numeric(18, 10)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}