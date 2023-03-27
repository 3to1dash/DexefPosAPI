using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RestoreTransactionConfiguration : IEntityTypeConfiguration<RestoreTransaction>
{
    public void Configure(EntityTypeBuilder<RestoreTransaction> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}