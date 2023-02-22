using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UsersLogEntryConfiguration : IEntityTypeConfiguration<UsersLogEntry>
{


    public void Configure(EntityTypeBuilder<UsersLogEntry> builder)
    {
        builder.ToTable("Users_LogEntry");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.IpAddress).HasMaxLength(50);

        builder.Property(e => e.Location).HasMaxLength(550);

        builder.Property(e => e.LogInId).HasColumnName("LogInID");

        builder.Property(e => e.Pcname)
            .HasMaxLength(250)
            .HasColumnName("PCName");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}