using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PotentialCustomerConfiguration : IEntityTypeConfiguration<PotentialCustomer>
{
    public void Configure(EntityTypeBuilder<PotentialCustomer> builder)
    {
        builder.ToTable("PotentialCustomer");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(2000);

        builder.Property(e => e.AreaId).HasColumnName("AreaID");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.ClassId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ClassID");

        builder.Property(e => e.Company).HasMaxLength(2000);

        builder.Property(e => e.ContractNum).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Field).HasMaxLength(2000);

        builder.Property(e => e.GroupId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("GroupID");

        builder.Property(e => e.Mail).HasMaxLength(2000);

        builder.Property(e => e.Name).HasMaxLength(2000);

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Phone1).HasMaxLength(2000);

        builder.Property(e => e.Phone2).HasMaxLength(2000);

        builder.Property(e => e.Phone3).HasMaxLength(2000);

        builder.Property(e => e.PriorityId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PriorityID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8");
    }
}