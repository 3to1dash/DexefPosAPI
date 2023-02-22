using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorksPhotoConfiguration : IEntityTypeConfiguration<WorksPhoto>
{
    public void Configure(EntityTypeBuilder<WorksPhoto> builder)
    {
        builder.ToTable("Works_Photo");

        builder.ToTable(t => t.HasComment("صور الموظفين"));


        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WorkId).HasColumnName("WorkID");
    }
}