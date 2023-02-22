using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserOptionConfiguration : IEntityTypeConfiguration<UserOption>
{


    public void Configure(EntityTypeBuilder<UserOption> builder)
    {
        builder.HasNoKey();

        builder.ToTable("User_Option");

        builder.HasIndex(e => new { e.Name, e.Permission, e.Adds }, "missing_index_10_9_user_option");

        builder.HasIndex(e => new { e.Permission, e.Adds }, "missing_index_12_11_user_option");

        builder.HasIndex(e => new { e.Name, e.Permission, e.Prints }, "missing_index_160_159_user_option");

        builder.HasIndex(e => new { e.Permission, e.Prints }, "missing_index_162_161_user_option");

        builder.HasIndex(e => new { e.Name, e.Permission, e.Edits }, "missing_index_164_163_user_option");

        builder.HasIndex(e => new { e.Permission, e.Edits }, "missing_index_166_165_user_option");

        builder.HasIndex(e => new { e.Name, e.Permission, e.Searchs }, "missing_index_206_205_user_option");

        builder.HasIndex(e => new { e.Permission, e.Searchs }, "missing_index_208_207_user_option");

        builder.Property(e => e.Adds)
            .HasColumnName("adds")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deletes)
            .HasColumnName("deletes")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Edits)
            .HasColumnName("edits")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isuser)
            .HasColumnName("isuser")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MyId)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("MyID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Orders)
            .HasColumnName("orders")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Permission)
            .HasMaxLength(50)
            .HasColumnName("permission");

        builder.Property(e => e.PermissionId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("permissionID");

        builder.Property(e => e.Prints)
            .HasColumnName("prints")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Searchs)
            .HasColumnName("searchs")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.PermissionNavigation)
            .WithMany()
            .HasForeignKey(d => d.Permission)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_User_Option_User_Permission");
    }
}