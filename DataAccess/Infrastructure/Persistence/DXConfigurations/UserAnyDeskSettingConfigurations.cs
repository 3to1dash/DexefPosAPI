using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserAnyDeskSettingConfiguration : IEntityTypeConfiguration<UserAnyDeskSetting>
{
    public void Configure(EntityTypeBuilder<UserAnyDeskSetting> builder)
    {
        builder.ToTable("User_AnyDeskSetting");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Ip).HasMaxLength(50);

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.HasOne(d => d.UserNameNavigation)
            .WithMany(p => p.UserAnyDeskSettings)
            .HasForeignKey(d => d.UserName)
            .HasConstraintName("FK_User_AnyDeskSetting_Users");
    }
}