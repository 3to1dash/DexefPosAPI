using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkWorkDayConfiguration : IEntityTypeConfiguration<WorkWorkDay>
{


    public void Configure(EntityTypeBuilder<WorkWorkDay> builder)
    {
        builder.ToTable("Work_WorkDays");

        builder.ToTable(t => t.HasComment("ايام العمل الرسمية للموظفين"));

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

        builder.Property(e => e.Sun).HasColumnName("sun");

        builder.Property(e => e.Thu).HasColumnName("thu");

        builder.Property(e => e.Tue).HasColumnName("tue");

        builder.Property(e => e.Wed).HasColumnName("wed");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}