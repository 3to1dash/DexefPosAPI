using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustNetConfiguration : IEntityTypeConfiguration<CustNet>
{
    public void Configure(EntityTypeBuilder<CustNet> builder)
    {
        builder.ToTable("Cust_Net");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Credit).HasColumnName("credit");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Editinfo).HasColumnName("editinfo");

        builder.Property(e => e.Maketalab).HasColumnName("maketalab");

        builder.Property(e => e.Ourtalab).HasColumnName("ourtalab");

        builder.Property(e => e.PassWeb)
            .HasMaxLength(10)
            .HasColumnName("Pass_web")
            .IsFixedLength();

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SafeNumber)
            .HasMaxLength(10)
            .IsFixedLength();

        builder.Property(e => e.Sendnote).HasColumnName("sendnote");

        builder.Property(e => e.Stockprice).HasColumnName("stockprice");

        builder.Property(e => e.Stockvalue).HasColumnName("stockvalue");

        builder.Property(e => e.Talabnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("talabnum");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.WelcomeName).HasMaxLength(150);
    }
}