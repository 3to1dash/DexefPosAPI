using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.OrderId).HasColumnName("OrderID");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.RoleId)
            .HasMaxLength(50)
            .HasColumnName("RoleID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.System).HasMaxLength(10);

        builder.HasOne(d => d.RoleNavigation)
            .WithMany(p => p.Roles)
            .HasForeignKey(d => d.RoleId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Roles_User_Permission");
    }
}