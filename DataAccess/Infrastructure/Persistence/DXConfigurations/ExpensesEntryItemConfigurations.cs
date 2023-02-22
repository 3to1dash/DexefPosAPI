using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExpensesEntryItemConfiguration : IEntityTypeConfiguration<ExpensesEntryItem>
{


    public void Configure(EntityTypeBuilder<ExpensesEntryItem> builder)
    {
        builder.ToTable("Expenses_Entry_Items");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EstimateId).HasColumnName("EstimateID");

        builder.Property(e => e.KindId)
            .HasMaxLength(10)
            .HasColumnName("KindID")
            .IsFixedLength();

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid).HasColumnName("rowguid");

        builder.Property(e => e.ShipId).HasColumnName("ShipID");

        builder.Property(e => e.SpentId).HasColumnName("SpentID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}