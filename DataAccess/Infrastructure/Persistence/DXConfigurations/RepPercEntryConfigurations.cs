using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepPercEntryConfiguration : IEntityTypeConfiguration<RepPercEntry>
{


    public void Configure(EntityTypeBuilder<RepPercEntry> builder)
    {
        builder.ToTable("RepPerc_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.IsCredit).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.NetAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.ReSales).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RepAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.RepPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RepPercId).HasColumnName("RepPercID");

        builder.Property(e => e.RepType).HasMaxLength(20);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sales).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SliceAccountId).HasColumnName("SliceAccountID");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.SliceName).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WorkAccountId).HasColumnName("WorkAccountID");

        builder.Property(e => e.WorkId).HasColumnName("WorkID");
    }
}