using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencyDiffEntryConfiguration : IEntityTypeConfiguration<CurrencyDiffEntry>
{


    public void Configure(EntityTypeBuilder<CurrencyDiffEntry> builder)
    {
        builder.ToTable("CurrencyDiff_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Credit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Debit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Iscredit).HasColumnName("ISCredit");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}