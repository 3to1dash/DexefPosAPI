using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
{
    public void Configure(EntityTypeBuilder<Owner> builder)
    {
        builder.HasNoKey();

        builder.ToTable("owner");

        builder.Property(e => e.Adress)
            .HasMaxLength(100)
            .HasColumnName("adress");

        builder.Property(e => e.Firstraseed)
            .HasColumnType("money")
            .HasColumnName("firstraseed");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("num");

        builder.Property(e => e.Phone)
            .HasMaxLength(20)
            .HasColumnName("phone");

        builder.Property(e => e.Phone1)
            .HasMaxLength(20)
            .HasColumnName("phone1");

        builder.Property(e => e.Phone2)
            .HasMaxLength(20)
            .HasColumnName("phone2");

        builder.Property(e => e.Raseed)
            .HasColumnType("money")
            .HasColumnName("raseed");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Share)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("share");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");
    }
}