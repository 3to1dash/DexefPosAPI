using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class YearFinancialConfiguration : IEntityTypeConfiguration<YearFinancial>
{
    public void Configure(EntityTypeBuilder<YearFinancial> builder)
    {
        builder.ToTable("YearFinancial");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArchieveDt)
            .HasColumnType("datetime")
            .HasColumnName("ArchieveDT");

        builder.Property(e => e.AutoClose).HasDefaultValueSql("((1))");

        builder.Property(e => e.Caption).HasMaxLength(50);

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.MasterId).HasColumnName("MasterID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");

        builder.Property(e => e.UpdateDt)
            .HasColumnType("datetime")
            .HasColumnName("UpdateDT");

        builder.HasOne(d => d.Master)
            .WithMany(p => p.YearFinancials)
            .HasForeignKey(d => d.MasterId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_YearFinancial_YearFinancial_Master");
    }
}