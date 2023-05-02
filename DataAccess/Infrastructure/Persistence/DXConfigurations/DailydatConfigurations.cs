using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailydatConfiguration : IEntityTypeConfiguration<Dailydat>
{
    public void Configure(EntityTypeBuilder<Dailydat> builder)
    {
        builder.HasNoKey();

        builder.ToTable("dailydat");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dafter)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("dafter")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Fromid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromid");

        builder.Property(e => e.Idunique)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("idunique");

        builder.Property(e => e.Isdeleted)
            .HasColumnName("isdeleted")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc");

        builder.Property(e => e.ReDeal)
            .HasMaxLength(50)
            .HasColumnName("re_deal");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Toid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("toid");

        builder.Property(e => e.Value)
            .HasColumnType("money")
            .HasColumnName("value");
    }
}