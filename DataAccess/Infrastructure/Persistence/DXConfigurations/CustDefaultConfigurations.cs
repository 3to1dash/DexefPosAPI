using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustDefaultConfiguration : IEntityTypeConfiguration<CustDefault>
{
    public void Configure(EntityTypeBuilder<CustDefault> builder)
    {
        builder.ToTable("Cust_default");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address).HasDefaultValueSql("((0))");

        builder.Property(e => e.Area).HasDefaultValueSql("((0))");

        builder.Property(e => e.CustType).HasDefaultValueSql("((0))");

        builder.Property(e => e.Image).HasDefaultValueSql("((0))");

        builder.Property(e => e.PersonalId)
            .HasColumnName("PersonalID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PersonalLength).HasDefaultValueSql("((0))");

        builder.Property(e => e.Phone).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Txt1)
            .HasColumnName("txt1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt2)
            .HasColumnName("txt2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt3)
            .HasColumnName("txt3")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt4)
            .HasColumnName("txt4")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt5)
            .HasColumnName("txt5")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt6)
            .HasColumnName("txt6")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt7)
            .HasColumnName("txt7")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt8)
            .HasColumnName("txt8")
            .HasDefaultValueSql("((0))");
    }
}