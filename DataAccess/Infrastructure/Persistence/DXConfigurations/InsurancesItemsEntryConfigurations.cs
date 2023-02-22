using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class InsurancesItemsEntryConfiguration : IEntityTypeConfiguration<InsurancesItemsEntry>
{


    public void Configure(EntityTypeBuilder<InsurancesItemsEntry> builder)
    {
        builder.ToTable("InsurancesItemsEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .HasColumnName("code");

        builder.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

        builder.Property(e => e.InsurancesItemId).HasColumnName("InsurancesItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.PercentId).HasColumnName("PercentID");
    }
}