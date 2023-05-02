using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustPatientConfiguration : IEntityTypeConfiguration<CustPatient>
{
    public void Configure(EntityTypeBuilder<CustPatient> builder)
    {
        builder.ToTable("Cust_patient");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Adress)
            .HasMaxLength(50)
            .HasColumnName("adress");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Month)
            .HasMaxLength(50)
            .HasColumnName("month");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Phone)
            .HasMaxLength(50)
            .HasColumnName("phone");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Runnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("runnum");

        builder.Property(e => e.Sex)
            .HasMaxLength(50)
            .HasColumnName("sex");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.Year)
            .HasMaxLength(50)
            .HasColumnName("year");
    }
}