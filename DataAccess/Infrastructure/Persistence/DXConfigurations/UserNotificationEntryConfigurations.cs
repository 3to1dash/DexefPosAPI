using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserNotificationEntryConfiguration : IEntityTypeConfiguration<UserNotificationEntry>
{


    public void Configure(EntityTypeBuilder<UserNotificationEntry> builder)
    {
        builder.ToTable("User_NotificationEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AlarmType).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EditorType).HasMaxLength(50);

        builder.Property(e => e.FiedName).HasMaxLength(50);

        builder.Property(e => e.NotificationId).HasColumnName("NotificationID");

        builder.Property(e => e.Qty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SecondQty).HasColumnType("numeric(18, 5)");

        builder.HasOne(d => d.Notification)
            .WithMany(p => p.UserNotificationEntries)
            .HasForeignKey(d => d.NotificationId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_User_NotificationEntry_User_Notification");
    }
}