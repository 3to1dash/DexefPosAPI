namespace DataAccess.Helpers;

public static class AppStatics
{
    public static string[] UserSelectedPermissions = {
        "Sale", "ReSale", "SaleQoute", "SaleEstimate", "Purchase", "RePurchase", "PurchaseQuote", "PurchaseOrder",
        "cash_recieved", "cash_paid", "spend", "income", "Cust", "Vendor", "items", "DeleteGridRow", "saleforbid",
        "EditNumber", "EditDate", "billclass", "choosecolum", "CurrencyEdit", "CurrencyEditRate", "SetInvoiceDiscount",
        "SaleBillExtra", "EditItemDiscountInBill", "salebillcost", "editbillbounes", "Quotacontrol", "CanSaleFree",
        "CanSelectItemSerial", "AccountingDashBoard", "BankDashboard", "BanksReportsDashboard", "cash_paidDashBoard",
        "cash_recievedDashBoard", "ConsignmentDashBoard", "CustDashboard", "incomeDashBoard", "IssueRequestsDashBoard",
        "itemassemblyDashBoard", "ItemDashBoard", "itemdisassemblyDashBoard", "itemgiftDashBoard", "ProfitDashBoard",
        "PurchaseConfirmDashBoard", "PurchaseDashBoard", "PurchaseOrderDashBoard", "PurchaseQuoteDashBoard",
        "PurchaseQuoteRecieveDashBoard", "ReceiveRequestsDashBoard", "RePurchaseDashBoard", "ReSaleDashBoard",
        "ReSaleReviewDashBoard", "rptBillDashBoard", "RptCashDashBoard", "RPtCashMainLevelDashboard",
        "RptCustDashBoard", "RptItemDashBoard", "SaleConfirmDashBoard", "SaleDashBoard", "SaleEstimateDashBoard",
        "SaleOrderDashBoard", "SaleQouteDashBoard", "SaleReviewDashBoard", "spendDashBoard", "storagedealDashBoard",
        "StoreCharityDashBoard", "StoreConvertDashBoard", "StoreDashBoard", "StoreHalekDashBoard", "StoreINDashBoard",
        "StoreInTransferDashBoard", "StoreIssueDashBoard", "StoreOutDashBoard", "StoreOutTransferDashBoard",
        "StorePackingCancelDashBoard", "StorePackingDashBoard", "StorePackingOrderDashBoard", "StoreRecieveDashBoard",
        "StoreRequestsDashBoard", "StoreSendOrderDashBoard", "StoreTransferOrderDashBoard", "VendorDashboard", "26",
        "14", "21", "33", "RPtCashMainLevel", "dailyfinalreport", "rptcompanydaily", "AccountingReports"
    };

    public struct Dealings
    {
        // Purchase
        public const string Purchase = "Purchase";
        public const string PurchaseService = "PurchaseService";
        public const string RePurchase = "RePurchase";
        public const string PurchaseOrder = "PurchaseOrder";
        public const string PurchaseQuote = "PurchaseQuote";
        public const string PurchaseQuoteRecieve = "PurchaseQuoteRecieve";
        public const string PurchaseConfirm = "PurchaseConfirm";
        
        // Sale
        public const string Sale = "Sale";
        public const string ReSale = "ReSale";
        public const string ReSaleReview = "ReSaleReview";
        public const string SaleEstimate = "SaleEstimate";
        public const string SaleOrder = "SaleOrder";
        public const string SaleReserve = "SaleReserve";
        public const string SaleQoute = "SaleQoute";
        public const string SaleConfirm = "SaleConfirm";
        public const string SaleService = "SaleService";

        // Store
        public const string StoreRecieve = "StoreRecieve";
        public const string StoreIssue = "StoreIssue";
        public const string StoreIN = "StoreIN";
        public const string StoreOut = "StoreOut";
        public const string StoreConvert = "StoreConvert";
        public const string StoreTransferOrder = "StoreTransferOrder";
        public const string StoreTransferINConfirm = "StoreTransferINConfirm";
        public const string StoreTransferOutConfirm = "StoreTransferOutConfirm";
        public const string StoreCustINConfirm = "StoreCustINConfirm";
        public const string StoreCustOutConfirm = "StoreCustOutConfirm";
        public const string StoreInTransfer = "StoreInTransfer";
        public const string StoreOutTransfer = "StoreOutTransfer";
        public const string StoreAssembly = "StoreAssembly";
        public const string StoreDisAssembly = "StoreDisAssembly";
        public const string StoreAdjustment = "StoreAdjustment";
        public const string StoreAccountINConfirm = "StoreAccountINConfirm";
        public const string StoreAccountOutConfirm = "StoreAccountOutConfirm";
        public const string StoreOpening = "StoreOpening";
        public const string StoreHalek = "StoreHalek";
        public const string StoreCharity = "StoreCharity";
        public const string StorePackingOrder = "StorePackingOrder";
        public const string StorePacking = "StorePacking";
        public const string StorePackingCancel = "StorePackingCancel";
        public const string StoreSendOrder = "StoreSendOrder";

        // Consignment
        public const string RecieveConsignment = "RecieveConsignment";
        public const string ReturnConsignment = "ReturnConsignment";
        
        // Resturant
        public const string PosSale = "PosSale";
        public const string PosDelivery = "PosDelivery";
        public const string PosHall = "PosHall";
        public const string PosPendingDelivery = "PosPendingDelivery";
        public const string PosPendingHall = "PosPendingHall";

        // Cash
        public const string PayTaxes = "PayTaxes";
        public const string AdjustTaxes = "AdjustTaxes";
        public const string Taxes = "Taxes";
        public const string RepPerc = "RepPerc";
        public const string CashIncome = "CashIncome";
        public const string CashSpend = "CashSpend";
        public const string CheckSpend = "CheckSpend";
        public const string ExpensesBill = "ExpensesBill";
        public const string IncomeBill = "IncomeBill";
        public const string CheckIncome = "CheckIncome";


        // Customer
        public const string CustOpening = "CustOpening";
        public const string CustBadDebit = "CustBadDebit";
        public const string CustEmpty = "CustEmpty";
        public const string CustContract = "CustContract";
        public const string DebitNote = "DebitNote";
        public const string CreditNote = "CreditNote";

        public const string CustAdjustment = "CustAdjustment";
        public const string CustEshar = "CustEshar";
        public const string CustTransfer = "CustTransfer";
        public const string CustRecieveMoney = "CustRecieveMoney";
        public const string CustPayMoeny = "CustPayMoeny";
        public const string CustCashDiscount = "CustCashDiscount";
        public const string CustDiscount = "CustDiscount";
        public const string CustBounes = "CustBounes";
        public const string CustInstallment = "CustInstallment";
        public const string CustIssueloyalty = "CustIssueloyalty";
        public const string InstallmentProfit = "InstallmentProfit";
    }
}
