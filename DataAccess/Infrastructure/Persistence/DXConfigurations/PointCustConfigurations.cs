using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointCustConfiguration : IEntityTypeConfiguration<PointCust>
{


    public void Configure(EntityTypeBuilder<PointCust> builder)
    {
        builder.ToTable("Point_Cust");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.HasSms).HasColumnName("HasSMS");

        builder.Property(e => e.Mail).HasMaxLength(50);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Passowrd).HasMaxLength(50);

        builder.Property(e => e.Phone).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}