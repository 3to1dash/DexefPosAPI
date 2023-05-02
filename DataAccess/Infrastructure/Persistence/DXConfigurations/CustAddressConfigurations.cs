using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustAddressConfiguration : IEntityTypeConfiguration<CustAddress>
{
    public void Configure(EntityTypeBuilder<CustAddress> builder)
    {
        builder.ToTable("Cust_Address");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AdditionalNumber).HasMaxLength(50);

        builder.Property(e => e.Adress)
            .HasColumnName("adress")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.AppNumber).HasMaxLength(50);

        builder.Property(e => e.AreaId)
            .HasColumnName("AreaID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BuildingNumber).HasMaxLength(50);

        builder.Property(e => e.City).HasMaxLength(250);

        builder.Property(e => e.Company)
            .HasMaxLength(50)
            .HasColumnName("company");

        builder.Property(e => e.Contacttime)
            .HasColumnType("datetime")
            .HasColumnName("contacttime");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.GlobalLocationNumber).HasMaxLength(250);

        builder.Property(e => e.Governorate).HasMaxLength(250);

        builder.Property(e => e.LandMark).HasMaxLength(250);

        builder.Property(e => e.LevelNumber).HasMaxLength(50);

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Person)
            .HasMaxLength(50)
            .HasColumnName("person");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone3)
            .HasMaxLength(50)
            .HasColumnName("phone3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PostalNumber).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Street).HasMaxLength(250);

        builder.HasOne(d => d.Cust)
            .WithMany(p => p.CustAddresses)
            .HasForeignKey(d => d.CustId)
            .HasConstraintName("FK_Cust_Address_Cust");
    }
}