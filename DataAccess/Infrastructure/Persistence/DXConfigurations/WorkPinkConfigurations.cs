using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPinkConfiguration : IEntityTypeConfiguration<WorkPink>
{


    public void Configure(EntityTypeBuilder<WorkPink> builder)
    {
        builder.ToTable("work_pinks");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Endtime)
            .HasColumnType("datetime")
            .HasColumnName("endtime");

        builder.Property(e => e.Hours)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hours");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Starttime)
            .HasColumnType("datetime")
            .HasColumnName("starttime");
    }
}