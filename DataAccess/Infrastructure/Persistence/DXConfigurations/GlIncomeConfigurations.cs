using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class GlIncomeConfiguration : IEntityTypeConfiguration<GlIncome>
{
    public void Configure(EntityTypeBuilder<GlIncome> builder)
    {
        builder.ToTable("GL_income");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Balance1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("balance1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Balance2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("balance2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("credit1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("debit1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");
    }
}