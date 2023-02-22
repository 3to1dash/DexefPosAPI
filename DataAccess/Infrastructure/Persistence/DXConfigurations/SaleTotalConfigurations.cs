using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SaleTotalConfiguration : IEntityTypeConfiguration<SaleTotal>
{


    public void Configure(EntityTypeBuilder<SaleTotal> builder)
    {
        builder.ToTable("sale_total");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CurrencyValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("currency_value");

        builder.Property(e => e.Currencyid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("currencyid");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.DatVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("dat_val");

        builder.Property(e => e.DateValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("date_value");

        builder.Property(e => e.DisBill)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("dis_bill");

        builder.Property(e => e.DisDue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("dis_due");

        builder.Property(e => e.DisItem)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("dis_item");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.DueDt)
            .HasColumnType("datetime")
            .HasColumnName("due_dt");

        builder.Property(e => e.DueVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("due_val");

        builder.Property(e => e.Extra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extra");

        builder.Property(e => e.Isdeleted).HasColumnName("isdeleted");

        builder.Property(e => e.Net)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("net");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Recieved).HasColumnName("recieved");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StoreID");

        builder.Property(e => e.TaxVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax_val");

        builder.Property(e => e.TaxValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax_value");

        builder.Property(e => e.TheUser)
            .HasMaxLength(50)
            .HasColumnName("the_user");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");

        builder.Property(e => e.WorkPerc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("work_perc");

        builder.Property(e => e.WorkValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("work_value");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");
    }
}