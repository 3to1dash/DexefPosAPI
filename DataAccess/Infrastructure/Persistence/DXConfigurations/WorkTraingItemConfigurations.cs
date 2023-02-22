using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkTraingItemConfiguration : IEntityTypeConfiguration<WorkTraingItem>
{


    public void Configure(EntityTypeBuilder<WorkTraingItem> builder)
    {
        builder.ToTable("Work_TraingItems");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Address)
            .HasMaxLength(2000)
            .HasColumnName("address");

        builder.Property(e => e.Companycost).HasColumnName("companycost");

        builder.Property(e => e.Days)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("days");

        builder.Property(e => e.Incompany).HasColumnName("incompany");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}