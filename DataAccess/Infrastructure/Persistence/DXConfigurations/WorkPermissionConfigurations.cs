using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPermissionConfiguration : IEntityTypeConfiguration<WorkPermission>
{
    public void Configure(EntityTypeBuilder<WorkPermission> builder)
    {
        builder.ToTable("Work_Permission");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.FromDt).HasColumnType("date");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Period).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RequestNumber).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}