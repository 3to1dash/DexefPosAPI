using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalariesEntryConfiguration : IEntityTypeConfiguration<SalariesEntry>
{
    public void Configure(EntityTypeBuilder<SalariesEntry> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Salaries_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.IsAdd).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");

        builder.Property(e => e.ServiceId)
            .HasMaxLength(150)
            .HasColumnName("ServiceID");

        builder.Property(e => e.ServiceType).HasMaxLength(50);

        builder.Property(e => e.SubId).HasColumnName("SubID");

        builder.Property(e => e.Type).HasMaxLength(50);
    }
}