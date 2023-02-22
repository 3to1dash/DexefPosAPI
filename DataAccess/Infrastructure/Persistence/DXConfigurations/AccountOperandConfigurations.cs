using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AccountOperandConfiguration : IEntityTypeConfiguration<AccountOperand>
{


    public void Configure(EntityTypeBuilder<AccountOperand> builder)
    {
        builder.HasKey(e => e.Operand);

        builder.ToTable("AccountOperand");

        builder.Property(e => e.Operand).HasMaxLength(50);

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}