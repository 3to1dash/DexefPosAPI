using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointCustomerConfiguration : IEntityTypeConfiguration<PointCustomer>
{


    public void Configure(EntityTypeBuilder<PointCustomer> builder)
    {
        builder.ToTable("Point_Customer");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Balance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CardId).HasColumnName("CardID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.InPoint).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OutPoint)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TotalPoint)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}