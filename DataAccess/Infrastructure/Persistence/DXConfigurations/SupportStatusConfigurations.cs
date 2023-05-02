using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportStatusConfiguration : IEntityTypeConfiguration<SupportStatus>
{
    public void Configure(EntityTypeBuilder<SupportStatus> builder)
    {
        builder.ToTable("Support_Status");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Description).HasMaxLength(550);

        builder.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.StatusId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StatusID");
    }
}