using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ContractConfiguration : IEntityTypeConfiguration<Contract>
{


    public void Configure(EntityTypeBuilder<Contract> builder)
    {
        builder.HasNoKey();

        builder.ToTable("contract");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Adress)
            .HasMaxLength(200)
            .HasColumnName("adress");

        builder.Property(e => e.Advisore)
            .HasMaxLength(50)
            .HasColumnName("advisore");

        builder.Property(e => e.Cust)
            .HasMaxLength(50)
            .HasColumnName("cust");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dtend)
            .HasColumnType("datetime")
            .HasColumnName("dtend");

        builder.Property(e => e.Dtexp)
            .HasColumnType("datetime")
            .HasColumnName("dtexp");

        builder.Property(e => e.Dtstart)
            .HasColumnType("datetime")
            .HasColumnName("dtstart");

        builder.Property(e => e.Ensure)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("ensure");

        builder.Property(e => e.Intercepts)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("intercepts");

        builder.Property(e => e.Money)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("money");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Reensureend)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("reensureend");

        builder.Property(e => e.Reensurestart)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("reensurestart");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Spent)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("spent");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");
    }
}