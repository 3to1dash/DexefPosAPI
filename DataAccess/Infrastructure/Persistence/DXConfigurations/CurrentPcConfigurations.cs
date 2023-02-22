using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrentPcConfiguration : IEntityTypeConfiguration<CurrentPc>
{


    public void Configure(EntityTypeBuilder<CurrentPc> builder)
    {
        builder.ToTable("CurrentPC");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.PcName).HasMaxLength(50);

        builder.Property(e => e.Pcnumber).HasColumnName("PCNumber");

        builder.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sn)
            .HasMaxLength(150)
            .HasColumnName("SN");

        builder.Property(e => e.Username).HasMaxLength(50);
    }
}