using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripTicketTempConfiguration : IEntityTypeConfiguration<TripTicketTemp>
{


    public void Configure(EntityTypeBuilder<TripTicketTemp> builder)
    {
        builder.ToTable("Trip_TicketTemp");

        builder.HasIndex(e => new { e.BranchId, e.CustId, e.Dt, e.Status }, "IX_Trip_TicketTemp_BranchID_CustID_DT_Status_E6BC6");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_0A1EF");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_0FEF5");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_114FF");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_1A305");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_1CCDD");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_1D4E7");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_2128E");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_26377");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_30F2A");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_3349C");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_34992");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_37274");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_380B8");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_38880");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_3FDD1");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_406E4");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_48CB5");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_52F8E");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_53CEC");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_64F55");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_6779F");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_732A4");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_73ABF");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_76D47");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_7C0F0");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_862C5");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_8697B");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_90F9B");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_933BF");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_9E527");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_A5BA2");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_AD666");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.AirLineVendorComm }, "IX_Trip_TicketTemp_BranchID_DT_AirLineVendorComm_5FBB9");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.AirLineVendorComm }, "IX_Trip_TicketTemp_BranchID_DT_AirLineVendorComm_AB81F");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_B2583");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_C0E2A");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_C8269");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_D56BC");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_D600F");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_D6D37");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_DB3CB");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_E1410");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_E20F4");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_E3AB8");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_E7CD0");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_F033C");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_F0846");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_F2DD2");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_F6676");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_TicketTemp_BranchID_DT_F7022");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_0011E");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_00AED");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_09BAE");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_1F5BB");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_236C0");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_244B7");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_30737");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_37043");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_3EEB3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_44730");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_45B31");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_4C68F");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_62B76");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_65791");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_685F8");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_6BB21");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_6FED3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_768EB");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_83AA8");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_856C8");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_91E96");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_A5AB6");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_B5D18");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_BC62D");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_BC701");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_C2781");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_D44FB");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_D90B2");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_DCEFD");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_E5173");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_E83CE");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_F6F45");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.OfficeId }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_OfficeID_548A3");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.OfficeId }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_OfficeID_B991B");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_20FAD");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_33F7B");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_3850C");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_71751");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_74464");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_80B32");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_8EFE5");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_9E820");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_A1132");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_C733E");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_PNR_ED99D");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Passenger_0C84C");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_03DE7");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_3A638");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_4E262");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_5AD40");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_5BF1F");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_796FC");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_A3B64");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_AD2D9");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_C16FE");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_D8846");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_PNR_0D805");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_PNR_170CC");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate, e.Status, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_IssueDate_Status_PNR_94250");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.OfficeId }, "IX_Trip_TicketTemp_BranchID_DT_OfficeID_247B1");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.OfficeId }, "IX_Trip_TicketTemp_BranchID_DT_OfficeID_C4AB1");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_1E22D");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_2BCB4");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_2C692");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_47538");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_5F0AF");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_6B4AB");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_6DE51");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_70974");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_B845E");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_BAC80");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_C348F");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_ECCAA");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_DT_PNR_ED104");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_Passenger_1EA1C");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_Passenger_277C6");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_Passenger_41CB8");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_Passenger_6216A");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_TicketTemp_BranchID_DT_Passenger_F7275");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.SellComm }, "IX_Trip_TicketTemp_BranchID_DT_SellComm_080F1");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.SellComm }, "IX_Trip_TicketTemp_BranchID_DT_SellComm_5CEFC");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Status, e.VendorId, e.CustId }, "IX_Trip_TicketTemp_BranchID_DT_Status_VendorID_CustID_53CF5");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Status, e.VendorId, e.CustId }, "IX_Trip_TicketTemp_BranchID_DT_Status_VendorID_CustID_7CEBE");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Status, e.VendorId, e.CustId }, "IX_Trip_TicketTemp_BranchID_DT_Status_VendorID_CustID_B23FD");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Status, e.VendorId, e.CustId }, "IX_Trip_TicketTemp_BranchID_DT_Status_VendorID_CustID_FC279");

        builder.HasIndex(e => new { e.BranchId, e.OfficeId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_OfficeID_DT_IssueDate_Status_1F401");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Commision, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_Commision_DT_02D87");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Commision, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_Commision_DT_2E651");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Commision, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_Commision_DT_9665C");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Commision, e.Dt, e.Pnr }, "IX_Trip_TicketTemp_BranchID_Status_Commision_DT_PNR_15C6F");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_1CCB0");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_20C38");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_39038");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_57C55");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_9C573");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_DT_E856A");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_0DB2E");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_0F6B4");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_14FBC");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_2C5A3");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_2D1F6");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_384AA");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_64A27");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_64FBB");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_6AD8E");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_98780");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_A7D22");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_BD58C");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_E4181");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Status_DT_IssueDate_EA2D4");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.NetTotal }, "IX_Trip_TicketTemp_BranchID_Status_DT_NetTotal_5A90F");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.NetTotal }, "IX_Trip_TicketTemp_BranchID_Status_DT_NetTotal_7A2ED");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.NetTotal }, "IX_Trip_TicketTemp_BranchID_Status_DT_NetTotal_EDC38");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.VendorCost, e.Dt }, "IX_Trip_TicketTemp_BranchID_Status_VendorCost_DT_C7689");

        builder.HasIndex(e => new { e.BranchId, e.TicketNumber, e.Dt }, "IX_Trip_TicketTemp_BranchID_TicketNumber_DT_C6367");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_0EA99");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_1645F");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_1D3E6");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_2C97C");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_51867");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_55140");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_5CC7E");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_92ACF");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_983AA");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_A043C");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_CDDCE");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_E1F30");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_21CFD");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_228C0");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_2F28B");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_42548");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_560C2");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_7E427");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_883A6");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_926C6");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_D14F5");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_2B801");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_56DD1");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_687D2");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_68EC3");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_935E3");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_A475E");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_C2D3F");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_E15D2");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_E2497");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.Dt, e.IssueDate, e.Status }, "IX_Trip_TicketTemp_BranchID_Trip_GdsId_DT_IssueDate_Status_E7377");

        builder.HasIndex(e => new { e.BranchId, e.VendorCost, e.Dt }, "IX_Trip_TicketTemp_BranchID_VendorCost_DT_946DE");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_TicketTemp_BranchID_VendorID_DT_822BA");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_TicketTemp_BranchID_VendorID_DT_DB000");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt, e.Status }, "IX_Trip_TicketTemp_BranchID_VendorID_DT_Status_2F7DE");

        builder.HasIndex(e => e.CustId, "IX_Trip_TicketTemp_CustID_7F27B");

        builder.HasIndex(e => e.Pnr, "IX_Trip_TicketTemp_PNR_06CD3");

        builder.HasIndex(e => new { e.TicketNumber, e.Status, e.VendorId }, "IX_Trip_TicketTemp_TicketNumber_Status_VendorID_D95C2");

        builder.HasIndex(e => e.UserCode, "IX_Trip_TicketTemp_UserCode_1CE27");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AirLineCustomerComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.AirLineCustomerId).HasColumnName("AirLineCustomerID");

        builder.Property(e => e.AirLineCustomerPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.AirLineId).HasColumnName("AirLineID");

        builder.Property(e => e.AirLinePurchaseVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("AirLinePurchaseVAT");

        builder.Property(e => e.AirLineSellVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("AirLineSellVAT");

        builder.Property(e => e.AirLineVendorComm)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AirLineVendorPerc)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Amount1)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount2)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount3)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ArriveCity).HasMaxLength(50);

        builder.Property(e => e.ArriveDate).HasMaxLength(50);

        builder.Property(e => e.ArriveTime).HasMaxLength(50);

        builder.Property(e => e.BillNum)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CancelFees).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CarrierCode).HasMaxLength(50);

        builder.Property(e => e.Class).HasMaxLength(40);

        builder.Property(e => e.Commision).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.CommisionPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CommisionVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("CommisionVAT");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Cpu).HasColumnName("CPU");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustPeriodId).HasColumnName("CustPeriodID");

        builder.Property(e => e.CustomerCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DepartCity).HasMaxLength(50);

        builder.Property(e => e.DepartDate).HasMaxLength(50);

        builder.Property(e => e.DepartTime).HasMaxLength(50);

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FileName).HasMaxLength(50);

        builder.Property(e => e.FlightNumber)
            .HasMaxLength(50)
            .HasColumnName("FLightNumber");

        builder.Property(e => e.IataNumber).HasMaxLength(50);

        builder.Property(e => e.IssueDate).HasColumnType("datetime");

        builder.Property(e => e.NetAmount)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.NetTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OfficeId)
            .HasMaxLength(50)
            .HasColumnName("OfficeID");

        builder.Property(e => e.OldTicketNumber).HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Passenger).HasMaxLength(250);

        builder.Property(e => e.PassengerMail).HasMaxLength(150);

        builder.Property(e => e.PassengerPhone).HasMaxLength(100);

        builder.Property(e => e.PassengerType).HasMaxLength(50);

        builder.Property(e => e.PayAmount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Pnr)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("PNR");

        builder.Property(e => e.Prefix)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.PurchaseAirlineVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseAirlineVAT");

        builder.Property(e => e.PurchaseComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PurchaseCommId).HasColumnName("PurchaseCommID");

        builder.Property(e => e.PurchaseCommPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PurchaseSliceCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseSliceCommVAT");

        builder.Property(e => e.PurchaseTicketVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseTicketVAT");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Routes).HasMaxLength(350);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCostId).HasColumnName("SaleCostID");

        builder.Property(e => e.SaleId).HasColumnName("SaleID");

        builder.Property(e => e.SellAirLineVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellAirLineVAT");

        builder.Property(e => e.SellComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.SellCommId).HasColumnName("SellCommID");

        builder.Property(e => e.SellCommPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SellCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellCommVAT");

        builder.Property(e => e.SellSliceCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellSliceCommVAT");

        builder.Property(e => e.SellTicketVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellTicketVAT");

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax1)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax2)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax3)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax4)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAddittion).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAfterComm).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalAfterVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("TotalAfterVAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTax).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTaxes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TripGdsId).HasColumnName("Trip_GdsId");

        builder.Property(e => e.TripUsersId).HasColumnName("Trip_UsersId");

        builder.Property(e => e.UserCode).HasMaxLength(50);

        builder.Property(e => e.Vat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("VAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.VendorId).HasColumnName("VendorID");

        builder.Property(e => e.VendorPeriodId).HasColumnName("VendorPeriodID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}