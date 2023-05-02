using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UsersPrivilegeConfiguration : IEntityTypeConfiguration<UsersPrivilege>
{
    public void Configure(EntityTypeBuilder<UsersPrivilege> builder)
    {
        builder.ToTable("Users_Privileges");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}