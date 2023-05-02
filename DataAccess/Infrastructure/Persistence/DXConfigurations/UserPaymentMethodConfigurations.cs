using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserPaymentMethodConfiguration : IEntityTypeConfiguration<UserPaymentMethod>
{
    public void Configure(EntityTypeBuilder<UserPaymentMethod> builder)
    {
        builder.ToTable("User_PaymentMethod");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Deal).HasDefaultValueSql("((1))");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SearchOnly).HasDefaultValueSql("((1))");
    }
}