using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripIatumConfiguration : IEntityTypeConfiguration<TripIatum>
{
    public void Configure(EntityTypeBuilder<TripIatum> builder)
    {
        builder.ToTable("Trip_IATA");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Notes).HasMaxLength(950);

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.PaymentDate).HasColumnType("date");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripIata)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_IATA_Company_Branch");

        builder.HasOne(d => d.Cust)
            .WithMany(p => p.TripIata)
            .HasForeignKey(d => d.CustId)
            .HasConstraintName("FK_Trip_IATA_Cust");
    }
}