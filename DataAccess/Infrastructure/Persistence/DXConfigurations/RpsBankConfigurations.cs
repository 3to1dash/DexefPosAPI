using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RpsBankConfiguration : IEntityTypeConfiguration<RpsBank>
{
    public void Configure(EntityTypeBuilder<RpsBank> builder)
    {
        builder.HasNoKey();

        builder.ToView("RpsBank");

        builder.Property(e => e.Arname).HasMaxLength(150);

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Branch)
            .HasMaxLength(50)
            .HasColumnName("branch");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Num)
            .HasMaxLength(150)
            .HasColumnName("num");
    }
}