using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DeliveryManConfiguration : IEntityTypeConfiguration<DeliveryMan>
{
    public void Configure(EntityTypeBuilder<DeliveryMan> builder)
    {
        builder.ToTable("DeliveryMan");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Name).HasMaxLength(250);

        builder.Property(e => e.Notes).HasMaxLength(550);

        builder.Property(e => e.Taxable).HasDefaultValueSql("((0))");
    }
}