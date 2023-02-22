using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TipConfiguration : IEntityTypeConfiguration<Tip>
{


    public void Configure(EntityTypeBuilder<Tip> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Tip");

        builder.Property(e => e.ArName)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChName)
            .HasColumnType("ntext")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(550)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName).HasColumnType("ntext");

        builder.Property(e => e.RoName)
            .HasColumnType("ntext")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasColumnType("ntext")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasColumnType("ntext")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasColumnType("ntext")
            .HasDefaultValueSql("('')");
    }
}