using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserDefaultInvoiceConfiguration : IEntityTypeConfiguration<UserDefaultInvoice>
{


    public void Configure(EntityTypeBuilder<UserDefaultInvoice> builder)
    {
        builder.ToTable("User_DefaultInvoice");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tags).HasMaxLength(50);

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}