using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CrmPreVisitConfiguration : IEntityTypeConfiguration<CrmPreVisit>
{
    public void Configure(EntityTypeBuilder<CrmPreVisit> builder)
    {
        builder.ToTable("Crm_PreVisit");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.FollowWith).HasMaxLength(150);

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.VisitDate).HasColumnType("datetime");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}