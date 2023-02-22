using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserStoreConfiguration : IEntityTypeConfiguration<UserStore>
{


    public void Configure(EntityTypeBuilder<UserStore> builder)
    {
        builder.ToTable("User_Stores");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Isdefault).HasColumnName("ISDefault");

        builder.Property(e => e.Issearch).HasColumnName("ISSearch");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");
    }
}