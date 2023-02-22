using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShBoxRecieveConfiguration : IEntityTypeConfiguration<ShBoxRecieve>
{


    public void Configure(EntityTypeBuilder<ShBoxRecieve> builder)
    {
        builder.ToTable("Sh_BoxRecieve");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Box).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BoxRent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IsMsg).HasDefaultValueSql("((1))");

        builder.Property(e => e.MsgId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("MsgID");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReBox).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReBoxRent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleRegNum).HasColumnType("numeric(18, 0)");
    }
}