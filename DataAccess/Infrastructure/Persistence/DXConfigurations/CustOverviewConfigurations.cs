using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustOverviewConfiguration : IEntityTypeConfiguration<CustOverview>
{


    public void Configure(EntityTypeBuilder<CustOverview> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Cust_overview");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Counts)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("counts");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dtbill)
            .HasColumnType("datetime")
            .HasColumnName("dtbill");

        builder.Property(e => e.Dtreciept)
            .HasColumnType("datetime")
            .HasColumnName("dtreciept");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Nondeal)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("nondeal");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Numbill)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("numbill");

        builder.Property(e => e.Numreciept)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("numreciept");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Valbill)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valbill");

        builder.Property(e => e.Valreciept)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valreciept");
    }
}