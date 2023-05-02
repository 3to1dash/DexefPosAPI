using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserPropertyConfiguration : IEntityTypeConfiguration<UserProperty>
{
    public void Configure(EntityTypeBuilder<UserProperty> builder)
    {
        builder.ToTable("User_Properties");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AlarmSave).HasDefaultValueSql("((1))");

        builder.Property(e => e.CashFlow).HasDefaultValueSql("((0))");

        builder.Property(e => e.Color).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsFake).HasDefaultValueSql("((0))");

        builder.Property(e => e.Lang).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SoundAlarm).HasDefaultValueSql("((1))");

        builder.Property(e => e.SoundDone).HasDefaultValueSql("((1))");

        builder.Property(e => e.SoundError).HasDefaultValueSql("((1))");

        builder.Property(e => e.UseEnter).HasDefaultValueSql("((1))");
    }
}