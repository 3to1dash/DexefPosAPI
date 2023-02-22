using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FixedAssetConfiguration : IEntityTypeConfiguration<FixedAsset>
{


    public void Configure(EntityTypeBuilder<FixedAsset> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Address).HasMaxLength(150);

        builder.Property(e => e.ArName).HasMaxLength(250);

        builder.Property(e => e.Area).HasMaxLength(50);

        builder.Property(e => e.AssetCostIn)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AssetCostOut)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AssetCostTotal)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.ChName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Code).HasMaxLength(150);

        builder.Property(e => e.Color).HasMaxLength(50);

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.CountryManufacture).HasMaxLength(50);

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dafter)
            .HasMaxLength(5)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeprecateCenterIn).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeprecateCenterOut).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeprecateCenterTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepreciationId).HasColumnName("DepreciationID");

        builder.Property(e => e.DepreciationRatio).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepreciationScrapValue).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DestoryDiscountId).HasColumnName("DestoryDiscountID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtExamination).HasColumnType("datetime");

        builder.Property(e => e.DtLicenseExpiration).HasColumnType("datetime");

        builder.Property(e => e.DtUsed).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.EmpName).HasMaxLength(50);

        builder.Property(e => e.EnName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Height).HasMaxLength(50);

        builder.Property(e => e.Length).HasMaxLength(50);

        builder.Property(e => e.LossesId).HasColumnName("LossesID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.ManufacturingCompany).HasMaxLength(50);

        builder.Property(e => e.Model).HasMaxLength(50);

        builder.Property(e => e.Neighbour1).HasMaxLength(50);

        builder.Property(e => e.Neighbour2).HasMaxLength(50);

        builder.Property(e => e.Neighbour3).HasMaxLength(50);

        builder.Property(e => e.OtherInsurancesId).HasColumnName("OtherInsurancesID");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ProfitsId).HasColumnName("ProfitsID");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyIn)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyOut)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyRent).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RecalcFlowId).HasColumnName("RecalcFlowID");

        builder.Property(e => e.RentAccountId).HasColumnName("RentAccountID");

        builder.Property(e => e.RoName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Room).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Store).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TuName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt1)
            .HasMaxLength(50)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(50)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(50)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(50)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(50)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(50)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(50)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(50)
            .HasColumnName("txt8");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(250)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Width).HasMaxLength(50);

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}