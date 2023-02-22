using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PrefrenceConfiguration : IEntityTypeConfiguration<Prefrence>
{


    public void Configure(EntityTypeBuilder<Prefrence> builder)
    {
        builder.HasKey(e => e.Name);

        builder.ToTable("Prefrence");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Deal)
            .HasMaxLength(250)
            .HasColumnName("deal");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.State)
            .HasColumnName("state")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt1)
            .HasMaxLength(500)
            .HasColumnName("txt1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(500)
            .HasColumnName("txt2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");
    }
}