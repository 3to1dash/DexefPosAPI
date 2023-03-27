using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustInstallmentConfiguration : IEntityTypeConfiguration<CustInstallment>
{
    public void Configure(EntityTypeBuilder<CustInstallment> builder)
    {
        builder.ToTable("Cust_Installment");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Counts).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("date");

        builder.Property(e => e.EveryDay).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Extra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Ismonth).HasColumnName("ISMonth");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaidValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayMonthly).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}