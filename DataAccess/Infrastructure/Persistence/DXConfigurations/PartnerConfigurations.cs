using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PartnerConfiguration : IEntityTypeConfiguration<Partner>
{


    public void Configure(EntityTypeBuilder<Partner> builder)
    {
        builder.ToTable("Partner");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(300);

        builder.Property(e => e.BranchId).HasColumnName("branchID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Employment).HasMaxLength(350);

        builder.Property(e => e.Mob1).HasMaxLength(100);

        builder.Property(e => e.Mob2).HasMaxLength(100);

        builder.Property(e => e.Mob3).HasMaxLength(100);

        builder.Property(e => e.Name)
            .HasMaxLength(350)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.PartnerGroupId).HasColumnName("PartnerGroupID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Txt1).HasMaxLength(250);

        builder.Property(e => e.Txt2).HasMaxLength(250);

        builder.Property(e => e.Txt3).HasMaxLength(250);

        builder.Property(e => e.Txt4).HasMaxLength(250);

        builder.Property(e => e.Txt5).HasMaxLength(250);

        builder.Property(e => e.Txt6).HasMaxLength(250);

        builder.Property(e => e.Txt7).HasMaxLength(250);

        builder.Property(e => e.Txt8).HasMaxLength(250);
    }
}