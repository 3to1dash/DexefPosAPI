using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindGroupEquationConfiguration : IEntityTypeConfiguration<KindGroupEquation>
{
    public void Configure(EntityTypeBuilder<KindGroupEquation> builder)
    {
        builder.ToTable("KindGroup_Equation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.EquationId).HasColumnName("EquationID");

        builder.Property(e => e.GroupId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("GroupID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}