using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CTenderConfiguration : IEntityTypeConfiguration<CTender>
{


    public void Configure(EntityTypeBuilder<CTender> builder)
    {
        builder.ToTable("C_Tender");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Address).HasMaxLength(250);

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.City).HasMaxLength(50);

        builder.Property(e => e.Country).HasMaxLength(50);

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("datetime");

        builder.Property(e => e.Job1).HasMaxLength(50);

        builder.Property(e => e.Job2).HasMaxLength(50);

        builder.Property(e => e.Job3).HasMaxLength(50);

        builder.Property(e => e.MyDataBase).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Name1).HasMaxLength(50);

        builder.Property(e => e.Name2).HasMaxLength(50);

        builder.Property(e => e.Name3).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(150);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.OrderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("OrderID");

        builder.Property(e => e.Phone1).HasMaxLength(50);

        builder.Property(e => e.Phone2).HasMaxLength(50);

        builder.Property(e => e.Phone3).HasMaxLength(50);

        builder.Property(e => e.Rate).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.State).HasMaxLength(50);

        builder.Property(e => e.ToAccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ToAccountID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Type).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WorkRegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");
    }
}