using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EditHistoryConfiguration : IEntityTypeConfiguration<EditHistory>
{


    public void Configure(EntityTypeBuilder<EditHistory> builder)
    {
        builder.ToTable("edit_history");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Billindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billindex");

        builder.Property(e => e.Bounes)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("bounes")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("dt");

        builder.Property(e => e.Extra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Theuser)
            .HasMaxLength(50)
            .HasColumnName("theuser")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Totalcost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("totalcost")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");
    }
}