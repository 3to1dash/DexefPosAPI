using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class Tempitemprofit1Configuration : IEntityTypeConfiguration<Tempitemprofit1>
{
    public void Configure(EntityTypeBuilder<Tempitemprofit1> builder)
    {
        builder.HasNoKey();

        builder.ToTable("tempitemprofit1");

        builder.Property(e => e.Kindcost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("kindcost");

        builder.Property(e => e.Kindcost1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("kindcost1");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}