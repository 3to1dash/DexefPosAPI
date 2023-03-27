using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXFilesConfigurations;

public class CustFileConfigurations : IEntityTypeConfiguration<CustFile>
{
    public void Configure(EntityTypeBuilder<CustFile> builder)
    {
        builder.ToTable("Cust_Files");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.AccountId).HasColumnName("AccountID");
        builder.Property(e => e.ArName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.Dealing).HasMaxLength(50);
        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.FileType).HasMaxLength(50);
        builder.Property(e => e.FrName).HasMaxLength(150);
        builder.Property(e => e.GroupId).HasColumnName("GroupID");
        builder.Property(e => e.OrginalFormat).HasMaxLength(50);
        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}