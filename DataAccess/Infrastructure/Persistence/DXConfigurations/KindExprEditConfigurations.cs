using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindExprEditConfiguration : IEntityTypeConfiguration<KindExprEdit>
{
    public void Configure(EntityTypeBuilder<KindExprEdit> builder)
    {
        builder.ToTable("kind_exprEdit");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Exprdt)
            .HasColumnType("datetime")
            .HasColumnName("exprdt");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Operate)
            .HasMaxLength(150)
            .HasColumnName("operate");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Valdiff)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valdiff");

        builder.Property(e => e.Valnew)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valnew");

        builder.Property(e => e.Valnow)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valnow");
    }
}