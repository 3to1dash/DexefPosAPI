using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PluginConfiguration : IEntityTypeConfiguration<Plugin>
{


    public void Configure(EntityTypeBuilder<Plugin> builder)
    {
        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.CategoryId)
            .HasMaxLength(50)
            .HasColumnName("CategoryID");

        builder.Property(e => e.DealingId)
            .HasMaxLength(50)
            .HasColumnName("DealingID");

        builder.Property(e => e.DesciptionId)
            .HasMaxLength(50)
            .HasColumnName("DesciptionID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShortCut).HasMaxLength(255);

        builder.Property(e => e.Sn).HasColumnName("SN");

        builder.Property(e => e.Snconfirm).HasColumnName("SNConfirm");

        builder.Property(e => e.Type).HasMaxLength(50);

        builder.Property(e => e.Xcolor)
            .HasMaxLength(255)
            .HasColumnName("XColor");

        builder.Property(e => e.Ximage)
            .HasMaxLength(50)
            .HasColumnName("XImage");
    }
}