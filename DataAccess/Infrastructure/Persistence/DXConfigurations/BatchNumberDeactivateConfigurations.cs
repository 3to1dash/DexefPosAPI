using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BatchNumberDeactivateConfiguration : IEntityTypeConfiguration<BatchNumberDeactivate>
{


    public void Configure(EntityTypeBuilder<BatchNumberDeactivate> builder)
    {
        builder.ToTable("Batch_NumberDeactivate");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BatchId).HasColumnName("BatchID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.Reason).HasMaxLength(150);

        builder.Property(e => e.RsdUserId).HasColumnName("RSD_UserID");
    }
}