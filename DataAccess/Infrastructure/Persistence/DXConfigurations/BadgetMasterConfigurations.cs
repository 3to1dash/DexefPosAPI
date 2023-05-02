using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetMasterConfiguration : IEntityTypeConfiguration<BadgetMaster>
{
    public void Configure(EntityTypeBuilder<BadgetMaster> builder)
    {
        builder.ToTable("Badget_Master");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dtstart)
            .HasColumnType("datetime")
            .HasColumnName("DTStart");

        builder.Property(e => e.IsautoPeriod).HasColumnName("ISAutoPeriod");

        builder.Property(e => e.IseditExpectedValue).HasColumnName("ISEditExpectedValue");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");
    }
}