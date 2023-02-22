using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FinalDatumConfiguration : IEntityTypeConfiguration<FinalDatum>
{


    public void Configure(EntityTypeBuilder<FinalDatum> builder)
    {
        builder.HasNoKey();

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NewCost).HasColumnType("decimal(38, 6)");

        builder.Property(e => e.SellDate).HasColumnType("datetime");

        builder.Property(e => e.SellQty).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}