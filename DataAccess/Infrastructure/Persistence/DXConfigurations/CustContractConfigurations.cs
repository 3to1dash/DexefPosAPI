using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustContractConfiguration : IEntityTypeConfiguration<CustContract>
{


    public void Configure(EntityTypeBuilder<CustContract> builder)
    {
        builder.ToTable("Cust_Contract");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtStartPayment).HasColumnType("datetime");

        builder.Property(e => e.Dtstart)
            .HasColumnType("datetime")
            .HasColumnName("DTStart");

        builder.Property(e => e.FirstMonthAmount)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsDebit).HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.Taxable).HasDefaultValueSql("((0))");

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalPaid)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}