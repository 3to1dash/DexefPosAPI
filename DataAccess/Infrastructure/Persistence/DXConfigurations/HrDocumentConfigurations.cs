using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrDocumentConfiguration : IEntityTypeConfiguration<HrDocument>
{


    public void Configure(EntityTypeBuilder<HrDocument> builder)
    {
        builder.ToTable("HR_Documents");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BeginDt)
            .HasColumnType("datetime")
            .HasColumnName("BeginDT");

        builder.Property(e => e.EndDt)
            .HasColumnType("datetime")
            .HasColumnName("EndDT");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Title).HasMaxLength(50);

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}