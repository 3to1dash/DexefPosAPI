using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustRatingConfiguration : IEntityTypeConfiguration<CustRating>
{
    public void Configure(EntityTypeBuilder<CustRating> builder)
    {
        builder.ToTable("Cust_Rating");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Level1)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level21)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level22)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level31)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level32)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level41)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level42)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Level5)
            .HasColumnType("decimal(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type).HasMaxLength(50);
    }
}