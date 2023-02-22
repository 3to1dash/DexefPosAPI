using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustDonationConfiguration : IEntityTypeConfiguration<CustDonation>
{


    public void Configure(EntityTypeBuilder<CustDonation> builder)
    {
        builder.HasKey(e => e.CustId);

        builder.ToTable("Cust_Donations");

        builder.Property(e => e.CustId)
            .ValueGeneratedNever()
            .HasColumnName("CustID");

        builder.Property(e => e.Memo).HasMaxLength(450);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}