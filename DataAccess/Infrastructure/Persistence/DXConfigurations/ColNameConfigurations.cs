using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ColNameConfiguration : IEntityTypeConfiguration<ColName>
{
    public void Configure(EntityTypeBuilder<ColName> builder)
    {
        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(50);

        builder.Property(e => e.ColName1)
            .HasMaxLength(50)
            .HasColumnName("ColName");

        builder.Property(e => e.EnName)
            .HasMaxLength(10)
            .IsFixedLength();

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TableName).HasMaxLength(50);
    }
}