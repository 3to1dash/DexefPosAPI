using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchaseCycleConfiguration : IEntityTypeConfiguration<PurchaseCycle>
{


    public void Configure(EntityTypeBuilder<PurchaseCycle> builder)
    {
        builder.ToTable("PurchaseCycle");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Cycle).HasMaxLength(10);

        builder.Property(e => e.Invoice).HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseOrder).HasDefaultValueSql("((0))");

        builder.Property(e => e.PurchaseQuote).HasDefaultValueSql("((0))");

        builder.Property(e => e.Review).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreIn).HasDefaultValueSql("((0))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}