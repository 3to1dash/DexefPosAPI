using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AlarmListConfiguration : IEntityTypeConfiguration<AlarmList>
{


    public void Configure(EntityTypeBuilder<AlarmList> builder)
    {
        builder.HasKey(e => e.FiedName);

        builder.ToTable("AlarmList");

        builder.Property(e => e.FiedName).HasMaxLength(50);

        builder.Property(e => e.AlarmGroup).HasMaxLength(50);

        builder.Property(e => e.AlarmType).HasMaxLength(50);

        builder.Property(e => e.ArDesc).HasMaxLength(750);

        builder.Property(e => e.ArName).HasMaxLength(250);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EditorType).HasMaxLength(50);

        builder.Property(e => e.FirstEditorType).HasMaxLength(50);

        builder.Property(e => e.FirstFieldName).HasMaxLength(50);

        builder.Property(e => e.FirstName).HasMaxLength(50);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Int).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isgroup).HasColumnName("ISGroup");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SecondEditorType).HasMaxLength(50);

        builder.Property(e => e.SecondFieldName).HasMaxLength(50);

        builder.Property(e => e.SecondName).HasMaxLength(50);

        builder.Property(e => e.YesNo).HasDefaultValueSql("((0))");
    }
}