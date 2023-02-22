using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UsersLogConfiguration : IEntityTypeConfiguration<UsersLog>
{


    public void Configure(EntityTypeBuilder<UsersLog> builder)
    {
        builder.ToTable("Users_Log");

        builder.HasIndex(e => new { e.UserName, e.LogIn, e.LogOut }, "NonClusteredIndex-20200304-142436");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Ipaddress)
            .HasMaxLength(50)
            .HasColumnName("IPAddress");

        builder.Property(e => e.LogInTime).HasColumnType("datetime");

        builder.Property(e => e.LogOutTime).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.HasOne(d => d.UserNameNavigation)
            .WithMany(p => p.UsersLogs)
            .HasForeignKey(d => d.UserName)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Users_Log_Users");
    }
}