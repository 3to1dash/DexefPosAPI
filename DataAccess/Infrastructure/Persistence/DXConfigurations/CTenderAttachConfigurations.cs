using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CTenderAttachConfiguration : IEntityTypeConfiguration<CTenderAttach>
{


    public void Configure(EntityTypeBuilder<CTenderAttach> builder)
    {
        builder.ToTable("C_TenderAttach");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.FileId)
            .HasMaxLength(2000)
            .HasColumnName("FileID");

        builder.Property(e => e.Folder).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TenderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TenderID");
    }
}