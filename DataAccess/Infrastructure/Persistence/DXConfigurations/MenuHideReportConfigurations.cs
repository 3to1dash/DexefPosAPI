using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MenuHideReportConfiguration : IEntityTypeConfiguration<MenuHideReport>
{


    public void Configure(EntityTypeBuilder<MenuHideReport> builder)
    {
        builder.ToTable("Menu_HideReport");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Appname)
            .HasMaxLength(255)
            .HasColumnName("APPName");

        builder.Property(e => e.DataId).HasColumnName("DataID");
    }
}