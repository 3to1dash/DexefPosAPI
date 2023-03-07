using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CompanyBranchConfiguration : IEntityTypeConfiguration<CompanyBranch>
{


    public void Configure(EntityTypeBuilder<CompanyBranch> builder)
    {
        builder.ToTable("Company_Branch");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.ActivityId)
            .HasMaxLength(50)
            .HasColumnName("ActivityID")
            .HasDefaultValueSql("((0))");

        //builder.Property(e => e.AdditionalNumber).HasMaxLength(50);

        //builder.Property(e => e.AppNumber).HasMaxLength(50);

        builder.Property(e => e.BuildingNumber).HasMaxLength(50);

        builder.Property(e => e.City)
            .HasMaxLength(50)
            .HasColumnName("city");

        builder.Property(e => e.CompanyId).HasColumnName("CompanyID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Country)
            .HasMaxLength(50)
            .HasColumnName("country");

        builder.Property(e => e.CountryId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CountryID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        //builder.Property(e => e.Field)
        //    .HasMaxLength(250)
        //    .HasColumnName("field");

        builder.Property(e => e.Governorate).HasMaxLength(50);

        builder.Property(e => e.Landmark).HasMaxLength(250);

        //builder.Property(e => e.Logo).HasColumnName("logo");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail");

        builder.Property(e => e.Mobile1)
            .HasMaxLength(20)
            .HasColumnName("mobile1");

        builder.Property(e => e.Mobile2)
            .HasMaxLength(20)
            .HasColumnName("mobile2");

        builder.Property(e => e.Mobile3)
            .HasMaxLength(20)
            .HasColumnName("mobile3");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        //builder.Property(e => e.PostalNumber).HasMaxLength(50);

        builder.Property(e => e.PurchaseCycle)
            .HasMaxLength(10)
            .HasDefaultValueSql("(N'P1')");

        builder.Property(e => e.PurchaseReview).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCycle)
            .HasMaxLength(10)
            .HasDefaultValueSql("(N'S1')");

        builder.Property(e => e.SaleReview).HasDefaultValueSql("((0))");

        builder.Property(e => e.Street)
            .HasMaxLength(450)
            .HasColumnName("street");

        builder.Property(e => e.Subcurrency)
            .HasMaxLength(50)
            .HasColumnName("subcurrency")
            .HasDefaultValueSql("('')");

        //builder.Property(e => e.Tax)
        //    .HasMaxLength(50)
        //    .HasColumnName("tax");

        builder.Property(e => e.TaxBranchId)
            .HasMaxLength(50)
            .HasColumnName("TaxBranchID");

        //builder.Property(e => e.Trade).HasMaxLength(50);

        builder.Property(e => e.TransferCycle)
            .HasMaxLength(10)
            .HasDefaultValueSql("(N'T1')");

        builder.Property(e => e.Val1)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Val2)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.HasOne(d => d.Company)
            .WithMany(p => p.CompanyBranches)
            .HasForeignKey(d => d.CompanyId)
            .HasConstraintName("FK_Company_Branch_Company");

        builder.HasOne(d => d.CountryNavigation)
            .WithMany(p => p.CompanyBranches)
            .HasForeignKey(d => d.CountryId)
            .HasConstraintName("FK_Company_Branch_Currency_Table");

        builder.HasMany(e => e.KindStocks)
            .WithOne(e => e.CompanyBranch)
            .HasForeignKey(e => e.BranchId);
    }
}