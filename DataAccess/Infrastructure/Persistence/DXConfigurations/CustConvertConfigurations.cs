using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustConvertConfiguration : IEntityTypeConfiguration<CustConvert>
{


    public void Configure(EntityTypeBuilder<CustConvert> builder)
    {
        builder.ToTable("Cust_Convert");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Fromcust)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromcust");

        builder.Property(e => e.Fromname)
            .HasMaxLength(50)
            .HasColumnName("fromname");

        builder.Property(e => e.Main)
            .HasMaxLength(50)
            .HasColumnName("main");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Renum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("renum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tocust)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("tocust");

        builder.Property(e => e.Toname)
            .HasMaxLength(50)
            .HasColumnName("toname");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}