using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FactoreInConfiguration : IEntityTypeConfiguration<FactoreIn>
{


    public void Configure(EntityTypeBuilder<FactoreIn> builder)
    {
        builder.ToTable("FactoreIN");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.BillIndex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("bill_index");

        builder.Property(e => e.Buy2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy2");

        builder.Property(e => e.Buy3)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy3");

        builder.Property(e => e.Checks)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("checks")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Custaccountid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custaccountid");

        builder.Property(e => e.Custdis)
            .HasColumnName("custdis")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dafter)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("dafter")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dat)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DAT");

        builder.Property(e => e.DatPercent)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DAtPercent");

        builder.Property(e => e.Discount)
            .HasColumnType("money")
            .HasColumnName("discount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountCurrent)
            .HasMaxLength(50)
            .HasColumnName("discount_current")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DiscountCurrentTotal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount_current_total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountCurrentval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount_currentval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("discountid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountitem)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("discountitem")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountitemid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("discountitemid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountkind)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountkind")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discountkindperc)
            .HasMaxLength(640)
            .HasColumnName("discountkindperc")
            .IsFixedLength();

        builder.Property(e => e.Discountperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discountperc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.DueDate)
            .HasColumnType("datetime")
            .HasColumnName("due_date")
            .HasDefaultValueSql("(((1999)/(1))/(1))");

        builder.Property(e => e.DueDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("due_discount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DueNote)
            .HasColumnName("due_note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DuePaid)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("due_paid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Expdt)
            .HasColumnType("datetime")
            .HasColumnName("expdt")
            .HasDefaultValueSql("('12:00:00')");

        builder.Property(e => e.Exprid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("exprid");

        builder.Property(e => e.Extraid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("extraid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Fromid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Idsale)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("idsale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Idsalecost)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("idsalecost")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdeleted)
            .HasColumnName("isdeleted")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdue)
            .HasColumnName("isdue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindcost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("kindcost");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("kindid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Machine)
            .HasMaxLength(50)
            .HasColumnName("machine");

        builder.Property(e => e.Maxvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("maxvalue");

        builder.Property(e => e.Money)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Moneyextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("moneyextra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Mountextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("mountextra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Operate)
            .HasMaxLength(50)
            .HasColumnName("operate");

        builder.Property(e => e.Price)
            .HasColumnType("money")
            .HasColumnName("price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Recieved)
            .HasColumnName("recieved")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RecievedDt)
            .HasColumnType("datetime")
            .HasColumnName("recieved_dt");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Remain)
            .HasColumnType("money")
            .HasColumnName("remain")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Represent)
            .HasMaxLength(50)
            .HasColumnName("represent")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Salecost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("salecost");

        builder.Property(e => e.Serial)
            .HasMaxLength(50)
            .HasColumnName("serial");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasColumnName("ship");

        builder.Property(e => e.Spend)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("spend")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Stock)
            .HasMaxLength(50)
            .HasColumnName("stock");

        builder.Property(e => e.TaxGroup)
            .HasMaxLength(50)
            .HasColumnName("tax_group")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.TaxValue)
            .HasColumnType("money")
            .HasColumnName("tax_value");

        builder.Property(e => e.Taxable)
            .HasColumnName("taxable")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Taxid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("taxid");

        builder.Property(e => e.Taxperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("taxperc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tempserial).HasColumnName("tempserial");

        builder.Property(e => e.Tempserial1).HasColumnName("tempserial1");

        builder.Property(e => e.TheUser)
            .HasMaxLength(50)
            .HasColumnName("the_user")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Toid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("toid")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("money")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalCur)
            .HasColumnType("money")
            .HasColumnName("total_cur");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Unite1)
            .HasMaxLength(50)
            .HasColumnName("unite1")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.ValUnite)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("val_unite")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ValUnite1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("val_unite1")
            .HasDefaultValueSql("((0))");
    }
}