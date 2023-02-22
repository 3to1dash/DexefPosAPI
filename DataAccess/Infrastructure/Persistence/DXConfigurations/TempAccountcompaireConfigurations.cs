using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempAccountcompaireConfiguration : IEntityTypeConfiguration<TempAccountcompaire>
{


    public void Configure(EntityTypeBuilder<TempAccountcompaire> builder)
    {
        builder.ToTable("temp_accountcompaire");

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

        builder.Property(e => e.Credit1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("credit1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("credit2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("debit1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("debit2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isparent).HasColumnName("isparent");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Parent)
            .HasMaxLength(50)
            .HasColumnName("parent");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");
    }
}