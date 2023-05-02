using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserNotificationConfiguration : IEntityTypeConfiguration<UserNotification>
{
    public void Configure(EntityTypeBuilder<UserNotification> builder)
    {
        builder.ToTable("User_Notification");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UseAccounts).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseHr)
            .HasColumnName("UseHR")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UsePurchase).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseSale).HasDefaultValueSql("((0))");

        builder.Property(e => e.UseStores).HasDefaultValueSql("((0))");
    }
}