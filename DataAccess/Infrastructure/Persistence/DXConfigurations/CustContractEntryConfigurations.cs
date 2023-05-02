using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustContractEntryConfiguration : IEntityTypeConfiguration<CustContractEntry>
{
    public void Configure(EntityTypeBuilder<CustContractEntry> builder)
    {
        builder.ToTable("Cust_Contract_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ContractId).HasColumnName("ContractID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Paid)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidDt).HasColumnType("datetime");

        builder.Property(e => e.Remain).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Runing).HasDefaultValueSql("((0))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");
    }
}