using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain.Models;

public class Cust
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public decimal Balance { get; set; }
    public decimal LocalDebit { get; set; }
    public decimal LocalCredit { get; set; }
    public decimal? LocalBalance { get; set; }
    public byte? TypeIndex { get; set; }
    public int? CustIndex { get; set; }
    public int? ParentId { get; set; }
    public string? Num { get; set; }
    public string? FirstName { get; set; }
    public string Name { get; set; } = null!;
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public bool? NoteIsImportant { get; set; }
    public string? Kind { get; set; }
    public string? PageNum { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Isdebit { get; set; }
    public int? Type { get; set; }
    public decimal? CreditLimit { get; set; }
    public int? PriceLevel { get; set; }
    public string? Prefix { get; set; }
    public int? Costid { get; set; }
    public int? Accountid { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Phone3 { get; set; }
    public string? PersonalId { get; set; }
    public string? Mail { get; set; }
    public DateTime? Contacttime { get; set; }
    public int? AreaId { get; set; }
    public string? Adress { get; set; }
    public int? GroupDiscount { get; set; }
    public int? CashDiscount { get; set; }
    public bool? Taxable { get; set; }
    public int? Tax { get; set; }
    public string? TaxFile { get; set; }
    public string? TaxDoc { get; set; }
    public string? TaxGov { get; set; }
    public string? TradeRegister { get; set; }
    public string? Company { get; set; }
    public string? Person { get; set; }
    public string? Banknum { get; set; }
    public string? Bankname { get; set; }
    public string? Bankbranch { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public decimal? OpeningBalance { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? FromId { get; set; }
    public DateTime? Lstoprdt { get; set; }
    public decimal? Lstoprval { get; set; }
    public string? Tempuse { get; set; }
    public DateTime? LastCall { get; set; }
    public decimal? Val1 { get; set; }
    public decimal? Val2 { get; set; }
    public decimal? RemainBill { get; set; }
    public decimal? RemainIsstall { get; set; }
    public decimal? RentDebit { get; set; }
    public decimal? RentCredit { get; set; }
    public decimal? RentBalance { get; set; }
    public string? ContractNum { get; set; }
    public bool? ShowInAll { get; set; }
    public short? CalcMode { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public int? ShowIn { get; set; }
    public string? Nat { get; set; }
    public int? DefaultCash { get; set; }
    public int? RepId { get; set; }
    public decimal? TotalIncome { get; set; }
    public int? InPoints { get; set; }
    public int? OutPoints { get; set; }
    public int? Netpoints { get; set; }
    public int? PointCardCount { get; set; }
    public bool? IsloyaltyProgram { get; set; }
    public bool? HasInsurance { get; set; }
    public string? InsuranceNum { get; set; }
    public int? InsuranceCompanyId { get; set; }
    public int? InsurancePercentId { get; set; }
    public Guid Rowguid { get; set; }
    public decimal? CountryId { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Governorate { get; set; }
    public int? ParentCustId { get; set; }
    public bool? IsMix { get; set; }
    public string? Gln { get; set; }
    public string? PostalNumber { get; set; }
    public decimal? CurrencyId { get; set; }

    [NotMapped] public virtual List<CustAddress> CustAddresses { get; set; }
    [NotMapped] public virtual List<TripContract> TripContracts { get; set; }
    [NotMapped] public virtual List<TripIatum> TripIata { get; set; }
    [NotMapped] public virtual List<TripTicket> TripTicketCusts { get; set; }
    [NotMapped] public virtual List<TripTicket> TripTicketVendors { get; set; }
    [NotMapped] public virtual List<TripUser> TripUsers { get; set; }
}