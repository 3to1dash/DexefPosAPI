using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class QuickStartConfiguration : IEntityTypeConfiguration<QuickStart>
{
    public void Configure(EntityTypeBuilder<QuickStart> builder)
    {
        builder.ToTable("QuickStart");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AppName).HasMaxLength(50);

        builder.Property(e => e.ArDesc).HasMaxLength(550);

        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Assembly)
            .HasMaxLength(50)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.Frm).HasMaxLength(50);

        builder.Property(e => e.FrmSearch).HasMaxLength(50);

        builder.Property(e => e.IssearchCtrl).HasColumnName("ISSearchCtrl");

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Tags).HasMaxLength(50);

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.VisibleOrder).HasDefaultValueSql("((0))");
    }
}