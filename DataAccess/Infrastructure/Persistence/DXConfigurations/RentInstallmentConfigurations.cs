using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RentInstallmentConfiguration : IEntityTypeConfiguration<RentInstallment>
{


    public void Configure(EntityTypeBuilder<RentInstallment> builder)
    {
        builder.ToTable("RentInstallment");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.RentId).HasColumnName("RentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}