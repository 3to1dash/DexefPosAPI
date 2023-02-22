using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class IncomeConfiguration : IEntityTypeConfiguration<Income>
{


    public void Configure(EntityTypeBuilder<Income> builder)
    {
        builder.ToTable("Income");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Bankid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("bankid");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CashType)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("cash_type");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Oadress)
            .HasMaxLength(350)
            .HasColumnName("oadress");

        builder.Property(e => e.Ofield)
            .HasMaxLength(50)
            .HasColumnName("ofield");

        builder.Property(e => e.Oname)
            .HasMaxLength(350)
            .HasColumnName("oname");

        builder.Property(e => e.Ophone)
            .HasMaxLength(50)
            .HasColumnName("ophone");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasColumnName("ship");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}