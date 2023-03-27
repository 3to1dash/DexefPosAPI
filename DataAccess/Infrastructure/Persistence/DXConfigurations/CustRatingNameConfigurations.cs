using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustRatingNameConfiguration : IEntityTypeConfiguration<CustRatingName>
{
    public void Configure(EntityTypeBuilder<CustRatingName> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Cust_RatingName");

        builder.Property(e => e.Name1).HasMaxLength(50);

        builder.Property(e => e.Name2).HasMaxLength(50);

        builder.Property(e => e.Name3).HasMaxLength(50);

        builder.Property(e => e.Name4).HasMaxLength(50);

        builder.Property(e => e.Name5).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}