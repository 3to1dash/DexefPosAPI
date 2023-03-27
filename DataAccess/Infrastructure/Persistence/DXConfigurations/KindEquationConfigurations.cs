using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindEquationConfiguration : IEntityTypeConfiguration<KindEquation>
{
    public void Configure(EntityTypeBuilder<KindEquation> builder)
    {
        builder.ToTable("Kind_Equation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EquationId).HasColumnName("EquationID");

        builder.Property(e => e.KindId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("KindID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}