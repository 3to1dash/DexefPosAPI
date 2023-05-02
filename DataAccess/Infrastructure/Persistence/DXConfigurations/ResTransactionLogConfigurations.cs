using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResTransactionLogConfiguration : IEntityTypeConfiguration<ResTransactionLog>
{
    public void Configure(EntityTypeBuilder<ResTransactionLog> builder)
    {
        builder.ToTable("ResTransactionLog");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.PrevStatus).HasMaxLength(50);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}