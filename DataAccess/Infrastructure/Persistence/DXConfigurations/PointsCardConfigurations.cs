using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointsCardConfiguration : IEntityTypeConfiguration<PointsCard>
{


    public void Configure(EntityTypeBuilder<PointsCard> builder)
    {
        builder.HasKey(e => e.CardNumber)
            .HasName("PK_Points_Car");

        builder.ToTable("Points_Card");

        builder.Property(e => e.CardNumber).ValueGeneratedNever();

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId)
            .HasColumnName("branchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CapltalId).HasColumnName("CapltalID");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustMob).HasMaxLength(50);

        builder.Property(e => e.Email).HasMaxLength(150);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.InPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.IssueDt).HasColumnType("datetime");

        builder.Property(e => e.LastUse).HasColumnType("datetime");

        builder.Property(e => e.Netpoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.OutPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.Password).HasMaxLength(50);

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}