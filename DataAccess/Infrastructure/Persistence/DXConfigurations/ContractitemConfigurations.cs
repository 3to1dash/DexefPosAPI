using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ContractitemConfiguration : IEntityTypeConfiguration<Contractitem>
{


    public void Configure(EntityTypeBuilder<Contractitem> builder)
    {
        builder.HasNoKey();

        builder.ToTable("contractitem");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Cust)
            .HasMaxLength(50)
            .HasColumnName("cust");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .HasColumnName("detail");

        builder.Property(e => e.Item)
            .HasMaxLength(50)
            .HasColumnName("item");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}