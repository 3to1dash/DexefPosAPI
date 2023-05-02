using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AccountMonthlyConfiguration : IEntityTypeConfiguration<AccountMonthly>
{
    public void Configure(EntityTypeBuilder<AccountMonthly> builder)
    {
        builder.HasNoKey();

        builder.ToView("AccountMonthly");

        builder.Property(e => e.AccountName).HasMaxLength(400);

        builder.Property(e => e.AccountNumber).HasMaxLength(50);

        builder.Property(e => e.Credit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .HasColumnName("currency");

        builder.Property(e => e.Date).HasColumnType("datetime");

        builder.Property(e => e.Debit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.LocalCredit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LocalDebit).HasColumnType("decimal(38, 12)");
    }
}