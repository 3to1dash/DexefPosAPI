using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MenuConfiguration : IEntityTypeConfiguration<Menu>
{
    public void Configure(EntityTypeBuilder<Menu> builder)
    {
        builder.ToTable("Menu");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.ArName).HasMaxLength(255);

        builder.Property(e => e.Assembly).HasMaxLength(255);

        builder.Property(e => e.ChName).HasMaxLength(255);

        builder.Property(e => e.EnName).HasMaxLength(255);

        builder.Property(e => e.FrName).HasMaxLength(255);

        builder.Property(e => e.Frm).HasMaxLength(255);

        builder.Property(e => e.HelpLink).HasColumnType("ntext");

        builder.Property(e => e.IsRtl).HasColumnName("IsRTL");

        builder.Property(e => e.Isexternal).HasColumnName("ISExternal");

        builder.Property(e => e.IsiconOnly).HasColumnName("ISIconOnly");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.ReFrm).HasMaxLength(255);

        builder.Property(e => e.RoName).HasMaxLength(255);

        builder.Property(e => e.RuName).HasMaxLength(255);

        builder.Property(e => e.ShortCut).HasMaxLength(255);

        builder.Property(e => e.Tags).HasMaxLength(255);

        builder.Property(e => e.TuName).HasMaxLength(255);

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Xcolor)
            .HasMaxLength(255)
            .HasColumnName("XColor");

        builder.Property(e => e.Ximage)
            .HasMaxLength(50)
            .HasColumnName("XImage");

        builder.Property(e => e.Xsize).HasColumnName("XSize");

        builder.HasOne(d => d.PermissionNavigation)
            .WithMany(p => p.Menus)
            .HasForeignKey(d => d.Permission)
            .HasConstraintName("FK_Menu_User_Permission");
    }
}