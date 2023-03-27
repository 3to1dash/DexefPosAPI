using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrCreditCardConfiguration : IEntityTypeConfiguration<HrCreditCard>
{
    public void Configure(EntityTypeBuilder<HrCreditCard> builder)
    {
        builder.ToTable("HR_CreditCards");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CardId).HasColumnName("CardID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.DtExpiration).HasColumnType("datetime");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Limit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");
    }
}