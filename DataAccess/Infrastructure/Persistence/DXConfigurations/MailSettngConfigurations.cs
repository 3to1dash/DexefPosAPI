using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MailSettngConfiguration : IEntityTypeConfiguration<MailSettng>
{


    public void Configure(EntityTypeBuilder<MailSettng> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ChkSslrequired).HasColumnName("ChkSSLRequired");

        builder.Property(e => e.ClientCertName).HasMaxLength(150);

        builder.Property(e => e.CurrentUser).HasMaxLength(50);

        builder.Property(e => e.MailDomain).HasMaxLength(150);

        builder.Property(e => e.MailServer).HasMaxLength(150);

        builder.Property(e => e.Password).HasMaxLength(150);

        builder.Property(e => e.ProviderName).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SendFrom).HasMaxLength(150);

        builder.Property(e => e.UserName).HasMaxLength(150);
    }
}