using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrAssetConfiguration : IEntityTypeConfiguration<HrAsset>
{
    public void Configure(EntityTypeBuilder<HrAsset> builder)
    {
        builder.ToTable("HR_Assets");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DtAssigned).HasColumnType("datetime");

        builder.Property(e => e.DtReturned).HasColumnType("datetime");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Serial).HasMaxLength(150);
    }
}