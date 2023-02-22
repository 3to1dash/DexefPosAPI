using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UsersPrivilegesEntryConfiguration : IEntityTypeConfiguration<UsersPrivilegesEntry>
{


    public void Configure(EntityTypeBuilder<UsersPrivilegesEntry> builder)
    {
        builder.HasKey(e => e.MyId);

        builder.ToTable("Users_PrivilegesEntry");

        builder.Property(e => e.MyId).HasColumnName("MyID");

        builder.Property(e => e.Adds)
            .HasColumnName("adds")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deletes)
            .HasColumnName("deletes")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EditorValue).HasMaxLength(50);

        builder.Property(e => e.Edits)
            .HasColumnName("edits")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isuser)
            .HasColumnName("isuser")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Orders)
            .HasColumnName("orders")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Permission)
            .HasMaxLength(50)
            .HasColumnName("permission");

        builder.Property(e => e.PermissionId).HasColumnName("permissionID");

        builder.Property(e => e.Prints)
            .HasColumnName("prints")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.PrivilegeId).HasColumnName("privilegeID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Searchs)
            .HasColumnName("searchs")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.PermissionNavigation)
            .WithMany(p => p.UsersPrivilegesEntries)
            .HasForeignKey(d => d.Permission)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Users_PrivilegesEntry_User_Permission");

        builder.HasOne(d => d.Permission1)
            .WithMany(p => p.UsersPrivilegesEntries)
            .HasForeignKey(d => d.PermissionId)
            .HasConstraintName("FK_Users_PrivilegesEntry_Roles");

        builder.HasOne(d => d.Privilege)
            .WithMany(p => p.UsersPrivilegesEntries)
            .HasForeignKey(d => d.PrivilegeId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Users_PrivilegesEntry_Users_Privileges");
    }
}