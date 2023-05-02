using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempInhanddataAvgConfiguration : IEntityTypeConfiguration<TempInhanddataAvg>
{
    public void Configure(EntityTypeBuilder<TempInhanddataAvg> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_InhanddataAvg");

        builder.Property(e => e.QuantityinHand).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalPriceInHand)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("TotalPrice_InHand");
    }
}