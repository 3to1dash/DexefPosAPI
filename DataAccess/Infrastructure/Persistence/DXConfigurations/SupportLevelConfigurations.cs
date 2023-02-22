using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportLevelConfiguration : IEntityTypeConfiguration<SupportLevel>
{


    public void Configure(EntityTypeBuilder<SupportLevel> builder)
    {
        builder.ToTable("Support_Level");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TypeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TypeID");
    }
}