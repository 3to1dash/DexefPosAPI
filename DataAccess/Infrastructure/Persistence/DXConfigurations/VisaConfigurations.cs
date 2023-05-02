using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class VisaConfiguration : IEntityTypeConfiguration<Visa>
{
    public void Configure(EntityTypeBuilder<Visa> builder)
    {
        builder.ToTable("Visa");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId)
            .HasColumnName("CapitalID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LocalBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MaxNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.OpeningBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpeningRegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpeningTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}