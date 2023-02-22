using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BankConfiguration : IEntityTypeConfiguration<Bank>
{


    public void Configure(EntityTypeBuilder<Bank> builder)
    {
        builder.ToTable("Bank");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.AccountType).HasMaxLength(50);

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Adress)
            .HasMaxLength(150)
            .HasColumnName("adress");

        builder.Property(e => e.Arname).HasMaxLength(150);

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Branch)
            .HasMaxLength(50)
            .HasColumnName("branch");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .HasColumnName("currency");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.IsCredit).HasDefaultValueSql("((1))");

        builder.Property(e => e.LocalBalance).HasColumnType("money");

        builder.Property(e => e.LocalCredit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LocalDebit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail");

        builder.Property(e => e.Num)
            .HasMaxLength(150)
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Phone1)
            .HasMaxLength(20)
            .HasColumnName("phone1");

        builder.Property(e => e.Phone2)
            .HasMaxLength(20)
            .HasColumnName("phone2");

        builder.Property(e => e.Phone3)
            .HasMaxLength(20)
            .HasColumnName("phone3");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value)
            .HasColumnType("money")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}