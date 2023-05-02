using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripUserConfiguration : IEntityTypeConfiguration<TripUser>
{
    public void Configure(EntityTypeBuilder<TripUser> builder)
    {
        builder.ToTable("Trip_Users");

        builder.HasIndex(e => new {e.BranchId, e.TripGdsId}, "IX_Trip_Users_BranchID_ProvidorID_ABA06");

        builder.HasIndex(e => e.TripGdsId, "IX_Trip_Users_Trip_GdsId_9A8FE");

        builder.HasIndex(e => new {e.UserName, e.TripGdsId}, "IX_Trip_Users_UserName_ProvidorID_20D12");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ComId).HasColumnName("ComID");

        builder.Property(e => e.CommissionIncludeTaxes).HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Email).HasMaxLength(150);

        builder.Property(e => e.Mobile).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.OfficeidCode).HasMaxLength(50);

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.Phone).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TripGdsId).HasColumnName("Trip_GdsId");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripUsers)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_Users_Company_Branch");

        builder.HasOne(d => d.Cust)
            .WithMany(p => p.TripUsers)
            .HasForeignKey(d => d.CustId)
            .HasConstraintName("FK_Trip_Users_Cust");

        builder.HasOne(d => d.TripGds)
            .WithMany(p => p.TripUsers)
            .HasForeignKey(d => d.TripGdsId)
            .HasConstraintName("FK_Trip_Users_Trip_GDS");
    }
}