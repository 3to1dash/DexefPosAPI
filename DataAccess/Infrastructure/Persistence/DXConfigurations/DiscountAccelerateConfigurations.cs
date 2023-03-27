using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DiscountAccelerateConfiguration : IEntityTypeConfiguration<DiscountAccelerate>
{
    public void Configure(EntityTypeBuilder<DiscountAccelerate> builder)
    {
        builder.ToTable("discount_accelerate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("accountid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Maxday)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("maxday");

        builder.Property(e => e.Minday)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("minday");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}