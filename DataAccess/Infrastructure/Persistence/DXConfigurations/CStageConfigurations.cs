using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CStageConfiguration : IEntityTypeConfiguration<CStage>
{


    public void Configure(EntityTypeBuilder<CStage> builder)
    {
        builder.HasNoKey();

        builder.ToTable("C_Stage");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SubId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SubID");

        builder.Property(e => e.TenderId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TenderID");
    }
}