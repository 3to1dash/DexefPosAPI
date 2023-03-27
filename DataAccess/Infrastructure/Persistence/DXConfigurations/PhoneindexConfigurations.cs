using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PhoneindexConfiguration : IEntityTypeConfiguration<Phoneindex>
{
    public void Configure(EntityTypeBuilder<Phoneindex> builder)
    {
        builder.HasNoKey();

        builder.ToTable("phoneindex");

        builder.Property(e => e.Adress)
            .HasMaxLength(250)
            .HasColumnName("adress");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2");

        builder.Property(e => e.Phone3)
            .HasMaxLength(50)
            .HasColumnName("phone3");

        builder.Property(e => e.Phone4)
            .HasMaxLength(50)
            .HasColumnName("phone4");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}