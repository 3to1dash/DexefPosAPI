using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustBouneConfiguration : IEntityTypeConfiguration<CustBoune>
{


    public void Configure(EntityTypeBuilder<CustBoune> builder)
    {
        builder.ToTable("cust_bounes");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dt1)
            .HasColumnType("datetime")
            .HasColumnName("dt1");

        builder.Property(e => e.Dt2)
            .HasColumnType("datetime")
            .HasColumnName("dt2");

        builder.Property(e => e.Main)
            .HasMaxLength(50)
            .HasColumnName("main");

        builder.Property(e => e.Note)
            .HasMaxLength(350)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}