using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustRatingSystemConfiguration : IEntityTypeConfiguration<CustRatingSystem>
{


    public void Configure(EntityTypeBuilder<CustRatingSystem> builder)
    {
        builder.ToTable("Cust_RatingSystem");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.Level1)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level2)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level3)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level4)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level5)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}