using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempConvertConfiguration : IEntityTypeConfiguration<TempConvert>
{


    public void Configure(EntityTypeBuilder<TempConvert> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_Convert");

        builder.Property(e => e.Credit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Debit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DiffCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.InCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.OutCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}