using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SliceWorkDayConfiguration : IEntityTypeConfiguration<SliceWorkDay>
{


    public void Configure(EntityTypeBuilder<SliceWorkDay> builder)
    {
        builder.ToTable("Slice_WorkDays");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Fri).HasColumnName("fri");

        builder.Property(e => e.Mon).HasColumnName("mon");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sat).HasColumnName("sat");

        builder.Property(e => e.SliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SliceID");

        builder.Property(e => e.Sun).HasColumnName("sun");

        builder.Property(e => e.Thu).HasColumnName("thu");

        builder.Property(e => e.Tue).HasColumnName("tue");

        builder.Property(e => e.Wed).HasColumnName("wed");
    }
}