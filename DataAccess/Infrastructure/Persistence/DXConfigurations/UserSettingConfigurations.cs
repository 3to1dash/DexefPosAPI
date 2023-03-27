using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserSettingConfiguration : IEntityTypeConfiguration<UserSetting>
{
    public void Configure(EntityTypeBuilder<UserSetting> builder)
    {
        builder.ToTable("User_Settings");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AlarmSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_96')");

        builder.Property(e => e.ConfirmEdit).HasDefaultValueSql("((1))");

        builder.Property(e => e.ConfirmSave).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeleteSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_86')");

        builder.Property(e => e.ErrorSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_27')");

        builder.Property(e => e.ExitSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_60')");

        builder.Property(e => e.IsAlarmSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsDeleteSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsErrorSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsExitSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsSuccessSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsUpdateSound).HasDefaultValueSql("((1))");

        builder.Property(e => e.PreviewAfterSave).HasDefaultValueSql("((0))");

        builder.Property(e => e.PrintAfterSave).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SuccessSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_56')");

        builder.Property(e => e.UpdateSound)
            .HasMaxLength(50)
            .HasDefaultValueSql("(N'Sound_54')");

        builder.Property(e => e.UseEnterKey).HasDefaultValueSql("((0))");

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}