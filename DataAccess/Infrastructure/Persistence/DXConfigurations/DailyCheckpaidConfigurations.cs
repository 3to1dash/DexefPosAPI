using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyCheckpaidConfiguration : IEntityTypeConfiguration<DailyCheckpaid>
{


    public void Configure(EntityTypeBuilder<DailyCheckpaid> builder)
    {
        builder.ToTable("daily_checkpaid");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Bankbranch)
            .HasMaxLength(50)
            .HasColumnName("bankbranch");

        builder.Property(e => e.Bankid)
            .HasMaxLength(50)
            .HasColumnName("bankid");

        builder.Property(e => e.Bankname)
            .HasMaxLength(50)
            .HasColumnName("bankname");

        builder.Property(e => e.Banknum)
            .HasMaxLength(50)
            .HasColumnName("banknum");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Cpu).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency");

        builder.Property(e => e.Currencyvalue)
            .HasColumnType("money")
            .HasColumnName("currencyvalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Deal)
            .HasMaxLength(50)
            .HasColumnName("deal");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EnDealing)
            .HasMaxLength(50)
            .HasColumnName("en_dealing");

        builder.Property(e => e.Fromid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Idcheck).HasColumnName("idcheck");

        builder.Property(e => e.Main)
            .HasMaxLength(50)
            .HasColumnName("main");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.Owner)
            .HasMaxLength(50)
            .HasColumnName("owner");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.RequireDate)
            .HasColumnType("datetime")
            .HasColumnName("require_date");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.State)
            .HasMaxLength(50)
            .HasColumnName("state");

        builder.Property(e => e.Temp)
            .HasMaxLength(50)
            .HasColumnName("temp");

        builder.Property(e => e.Toid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("toid");

        builder.Property(e => e.Total)
            .HasColumnType("money")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("money")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}