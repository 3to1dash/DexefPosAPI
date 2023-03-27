using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AlarmsPostponedConfiguration : IEntityTypeConfiguration<AlarmsPostponed>
{
    public void Configure(EntityTypeBuilder<AlarmsPostponed> builder)
    {
        builder.ToTable("Alarms_Postponed");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AlarmType).HasMaxLength(50);

        builder.Property(e => e.PostponedDate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}