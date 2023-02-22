using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkVocConfiguration : IEntityTypeConfiguration<WorkVoc>
{


    public void Configure(EntityTypeBuilder<WorkVoc> builder)
    {
        builder.HasNoKey();

        builder.ToTable("work_voc");

        builder.Property(e => e.Forall).HasColumnName("forall");

        builder.Property(e => e.Groups)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("groups");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}