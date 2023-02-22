using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetSpentConfiguration : IEntityTypeConfiguration<AssetSpent>
{


    public void Configure(EntityTypeBuilder<AssetSpent> builder)
    {
        builder.ToTable("AssetSpent");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Assetid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Branchid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.ExpensId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ExpensID");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasColumnName("ship");

        builder.Property(e => e.SpentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SpentID");

        builder.Property(e => e.Store).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}