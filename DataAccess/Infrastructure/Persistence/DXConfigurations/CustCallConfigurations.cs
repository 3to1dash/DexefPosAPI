using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustCallConfiguration : IEntityTypeConfiguration<CustCall>
{
    public void Configure(EntityTypeBuilder<CustCall> builder)
    {
        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CallNumber).HasMaxLength(100);

        builder.Property(e => e.CallReson).HasMaxLength(250);

        builder.Property(e => e.CallState).HasMaxLength(50);

        builder.Property(e => e.CallType).HasMaxLength(50);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}