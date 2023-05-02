using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ContSpentConfiguration : IEntityTypeConfiguration<ContSpent>
{
    public void Configure(EntityTypeBuilder<ContSpent> builder)
    {
        builder.HasNoKey();

        builder.ToTable("cont_spent");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Billnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billnum");

        builder.Property(e => e.Cust)
            .HasMaxLength(50)
            .HasColumnName("cust");

        builder.Property(e => e.Custnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custnum");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Fromaccount)
            .HasMaxLength(50)
            .HasColumnName("fromaccount");

        builder.Property(e => e.Fromnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromnum");

        builder.Property(e => e.Item)
            .HasMaxLength(50)
            .HasColumnName("item");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Toaccount)
            .HasMaxLength(50)
            .HasColumnName("toaccount");

        builder.Property(e => e.Tonum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("tonum");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}