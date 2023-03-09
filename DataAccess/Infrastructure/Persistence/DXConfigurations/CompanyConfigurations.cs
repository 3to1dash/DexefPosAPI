using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Company");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ActivityId)
            .HasMaxLength(50)
            .HasColumnName("ActivityID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AdditionalNumber).HasMaxLength(50);

        builder.Property(e => e.AppNumber).HasMaxLength(50);

        builder.Property(e => e.BuildingNumber).HasMaxLength(50);

        builder.Property(e => e.City)
            .HasMaxLength(50)
            .HasColumnName("city");

        builder.Property(e => e.Country)
            .HasMaxLength(50)
            .HasColumnName("country");

        builder.Property(e => e.CountryId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CountryID");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Fax)
            .HasMaxLength(20)
            .HasColumnName("fax");

        builder.Property(e => e.Field)
            .HasMaxLength(250)
            .HasColumnName("field");

        builder.Property(e => e.Governorate).HasMaxLength(50);

        builder.Property(e => e.IsOnline).HasDefaultValueSql("((1))");

        builder.Property(e => e.Landmark).HasMaxLength(250);

        builder.Property(e => e.Logo).HasColumnName("logo");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail");

        builder.Property(e => e.Manager).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Phone)
            .HasMaxLength(20)
            .HasColumnName("phone");

        builder.Property(e => e.Phone1)
            .HasMaxLength(20)
            .HasColumnName("phone1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PostalNumber).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Street)
            .HasMaxLength(450)
            .HasColumnName("street");

        builder.Property(e => e.Subcurrency)
            .HasMaxLength(50)
            .HasColumnName("subcurrency")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Tax)
            .HasMaxLength(50)
            .HasColumnName("tax");

        builder.Property(e => e.Trade).HasMaxLength(50);

        //builder.HasOne(e => e.CurrencyTable)
        //    .WithOne()
        //    .HasPrincipalKey<Company>(e => e.Currency)
        //    .HasForeignKey<CurrencyTable>(e => e.Shortcut);

        builder.HasOne(c => c.CurrencyTable)
            .WithMany()
            .HasForeignKey(c => c.Currency)
            .HasPrincipalKey(ct => ct.Shortcut);
    }
}