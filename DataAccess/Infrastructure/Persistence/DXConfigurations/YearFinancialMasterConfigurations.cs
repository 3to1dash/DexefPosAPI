using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class YearFinancialMasterConfiguration : IEntityTypeConfiguration<YearFinancialMaster>
{
    public void Configure(EntityTypeBuilder<YearFinancialMaster> builder)
    {
        builder.ToTable("YearFinancial_Master");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");
    }
}