using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripGdConfiguration : IEntityTypeConfiguration<TripGd>
{


    public void Configure(EntityTypeBuilder<TripGd> builder)
    {
        builder.ToTable("Trip_GDS");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AirLineId)
            .HasColumnName("AirLineID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.FileExe).HasMaxLength(50);

        builder.Property(e => e.FilePath).HasMaxLength(950);

        builder.Property(e => e.Gdstype)
            .HasMaxLength(50)
            .HasColumnName("GDSType");

        builder.Property(e => e.IataId).HasColumnName("IataID");

        builder.Property(e => e.IsCommIncludeTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsaddCommission).HasColumnName("ISAddCommission");

        builder.Property(e => e.IslowCost)
            .HasColumnName("ISLowCost")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LoadTickets).HasColumnName("LoadTIckets");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Notes).HasMaxLength(950);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}