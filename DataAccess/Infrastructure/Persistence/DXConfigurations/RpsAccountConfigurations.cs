using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RpsAccountConfiguration : IEntityTypeConfiguration<RpsAccount>
{
    public void Configure(EntityTypeBuilder<RpsAccount> builder)
    {
        builder.HasNoKey();

        builder.ToView("RpsAccount");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Operands)
            .HasMaxLength(50)
            .HasColumnName("operands");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}