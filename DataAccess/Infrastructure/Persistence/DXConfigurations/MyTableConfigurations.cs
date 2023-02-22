using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MyTableConfiguration : IEntityTypeConfiguration<MyTable>
{


    public void Configure(EntityTypeBuilder<MyTable> builder)
    {
        builder.HasNoKey();

        builder.ToTable("myTable");

        builder.Property(e => e.Pic)
            .HasColumnType("image")
            .HasColumnName("pic");

        builder.Property(e => e.RowId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("rowId");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}