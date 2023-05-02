using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MenuHideFromConfiguration : IEntityTypeConfiguration<MenuHideFrom>
{
    public void Configure(EntityTypeBuilder<MenuHideFrom> builder)
    {
        builder.ToTable("Menu_HideFrom");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Appname)
            .HasMaxLength(255)
            .HasColumnName("APPName");

        builder.Property(e => e.DataId).HasColumnName("DataID");
    }
}