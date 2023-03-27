using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempFinalDatumConfiguration : IEntityTypeConfiguration<TempFinalDatum>
{
    public void Configure(EntityTypeBuilder<TempFinalDatum> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_FinalData");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NewCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}