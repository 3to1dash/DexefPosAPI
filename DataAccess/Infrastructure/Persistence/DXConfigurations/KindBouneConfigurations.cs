using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindBouneConfiguration : IEntityTypeConfiguration<KindBoune>
{


    public void Configure(EntityTypeBuilder<KindBoune> builder)
    {
        builder.ToTable("Kind_Bounes");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");
    }
}