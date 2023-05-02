using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExpensesItemsEntryConfiguration : IEntityTypeConfiguration<ExpensesItemsEntry>
{
    public void Configure(EntityTypeBuilder<ExpensesItemsEntry> builder)
    {
        builder.ToTable("ExpensesItems_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ExpensId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ExpensID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasMaxLength(50);
    }
}