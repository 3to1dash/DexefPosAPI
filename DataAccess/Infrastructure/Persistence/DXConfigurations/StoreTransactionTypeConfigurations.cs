using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class StoreTransactionTypeConfiguration : IEntityTypeConfiguration<StoreTransactionType>
{


    public void Configure(EntityTypeBuilder<StoreTransactionType> builder)
    {
        builder.ToTable("StoreTransactionType");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.ApproveUsers).HasMaxLength(50);

        builder.Property(e => e.AutomaticApprove).HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TransactionType).HasMaxLength(50);
    }
}