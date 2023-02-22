using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class NethistoryConfiguration : IEntityTypeConfiguration<Nethistory>
{


    public void Configure(EntityTypeBuilder<Nethistory> builder)
    {
        builder.ToTable("nethistory");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Answer).HasMaxLength(50);

        builder.Property(e => e.Email).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(50);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.Quest).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.Website).HasMaxLength(50);
    }
}