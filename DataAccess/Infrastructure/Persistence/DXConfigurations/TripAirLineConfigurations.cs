using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripAirLineConfiguration : IEntityTypeConfiguration<TripAirLine>
{


    public void Configure(EntityTypeBuilder<TripAirLine> builder)
    {
        builder.HasKey(e => e.Num);

        builder.ToTable("Trip_AirLines");

        builder.Property(e => e.Num)
            .HasMaxLength(5)
            .HasColumnName("num");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Adress)
            .HasMaxLength(100)
            .HasColumnName("adress");

        builder.Property(e => e.Code)
            .HasMaxLength(5)
            .HasColumnName("code");

        builder.Property(e => e.Country).HasMaxLength(150);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Mobile1)
            .HasMaxLength(20)
            .HasColumnName("mobile1");

        builder.Property(e => e.Mobile2)
            .HasMaxLength(20)
            .HasColumnName("mobile2");

        builder.Property(e => e.Mobile3)
            .HasMaxLength(20)
            .HasColumnName("mobile3");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}