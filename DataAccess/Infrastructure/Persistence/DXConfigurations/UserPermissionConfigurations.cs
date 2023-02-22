using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserPermissionConfiguration : IEntityTypeConfiguration<UserPermission>
{


    public void Configure(EntityTypeBuilder<UserPermission> builder)
    {
        builder.HasKey(e => e.Permission)
            .HasName("PK_user_permission");

        builder.ToTable("User_Permission");

        builder.Property(e => e.Permission)
            .HasMaxLength(50)
            .HasColumnName("permission");

        builder.Property(e => e.Adds)
            .HasColumnName("adds")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.ArName).HasMaxLength(250);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Deletes)
            .HasColumnName("deletes")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Dtname)
            .HasMaxLength(50)
            .HasColumnName("DTName");

        builder.Property(e => e.EditorType).HasMaxLength(50);

        builder.Property(e => e.Edits)
            .HasColumnName("edits")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.EnName).HasMaxLength(250);

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Isuser)
            .HasColumnName("isuser")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Orders)
            .HasColumnName("orders")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Prints)
            .HasColumnName("prints")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Searchs)
            .HasColumnName("searchs")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Shown).HasDefaultValueSql("((1))");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}