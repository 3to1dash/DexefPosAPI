using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UsersResourceConfiguration : IEntityTypeConfiguration<UsersResource>
{
    public void Configure(EntityTypeBuilder<UsersResource> builder)
    {
        builder.ToTable("Users_Resources");

        builder.HasIndex(e => new {e.UserName, e.Module}, "NonClusteredIndex-20200304-120552");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Ids).HasColumnName("IDs");

        builder.Property(e => e.Module).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}