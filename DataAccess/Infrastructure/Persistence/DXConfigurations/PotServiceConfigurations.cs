using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PotServiceConfiguration : IEntityTypeConfiguration<PotService>
{


    public void Configure(EntityTypeBuilder<PotService> builder)
    {
        builder.ToTable("Pot_Service");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AreaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AreaID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ServiceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ServiceID");
    }
}