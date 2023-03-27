using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustInfoConfiguration : IEntityTypeConfiguration<CustInfo>
{
    public void Configure(EntityTypeBuilder<CustInfo> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Cust_Info");

        builder.Property(e => e.Adress)
            .HasMaxLength(350)
            .HasColumnName("adress")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}