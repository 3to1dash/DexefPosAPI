using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class ExtraFieldDesignConfigurations : IEntityTypeConfiguration<ExtraFieldDesign>
{
    public void Configure(EntityTypeBuilder<ExtraFieldDesign> builder)
    {
        builder.ToTable("ExtraField_Design");

        builder.Property(e => e.Id).HasColumnName("ID");
        builder.Property(e => e.InvTypeId).HasColumnName("InvTypeID");
        builder.Property(e => e.Type).HasMaxLength(50);
    }
}