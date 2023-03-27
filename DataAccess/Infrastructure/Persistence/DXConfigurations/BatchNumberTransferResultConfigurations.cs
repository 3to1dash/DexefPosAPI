using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BatchNumberTransferResultConfiguration : IEntityTypeConfiguration<BatchNumberTransferResult>
{
    public void Configure(EntityTypeBuilder<BatchNumberTransferResult> builder)
    {
        builder.ToTable("Batch_number_TransferResult");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}