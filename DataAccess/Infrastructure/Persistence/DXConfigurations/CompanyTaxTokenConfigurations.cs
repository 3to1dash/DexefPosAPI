using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CompanyTaxTokenConfiguration : IEntityTypeConfiguration<CompanyTaxToken>
{


    public void Configure(EntityTypeBuilder<CompanyTaxToken> builder)
    {
        builder.ToTable("Company_TaxToken");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ClientId)
            .HasMaxLength(50)
            .HasColumnName("ClientID");

        builder.Property(e => e.ClientSecret1).HasMaxLength(50);

        builder.Property(e => e.ClientSecret2).HasMaxLength(50);

        builder.Property(e => e.CompanyId).HasColumnName("CompanyID");

        builder.Property(e => e.Country).HasMaxLength(50);

        builder.Property(e => e.Pin)
            .HasMaxLength(50)
            .HasColumnName("PIN");

        builder.HasOne(d => d.Company)
            .WithMany(p => p.CompanyTaxTokens)
            .HasForeignKey(d => d.CompanyId)
            .HasConstraintName("FK_Company_TaxToken_Company");
    }
}