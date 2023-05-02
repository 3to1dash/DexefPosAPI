using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplWorkShiftConfiguration : IEntityTypeConfiguration<EmplWorkShift>
{
    public void Configure(EntityTypeBuilder<EmplWorkShift> builder)
    {
        builder.ToTable("Empl_WorkShift");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShiftId).HasColumnName("ShiftID");
    }
}