using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class OnlineUserConfiguration : IEntityTypeConfiguration<OnlineUser>
{
    public void Configure(EntityTypeBuilder<OnlineUser> builder)
    {
        builder.ToTable("OnlineUser");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.LastLogIn)
            .HasColumnType("datetime")
            .HasColumnName("LastLogIN");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.OnlineSupport).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type).HasMaxLength(50);
    }
}