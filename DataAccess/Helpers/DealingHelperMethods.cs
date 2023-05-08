namespace DataAccess.Helpers;

public class DealingHelperMethods
{
    public static InvoiceinvoiceTypee LoadTableName(string dealing)
    {
        InvoiceinvoiceTypee invoiceType = new()
        {
            HasTransaction = true,
            LetSummaryOnly = true
        };

        switch (dealing)
        {
            case AppStatics.Dealings.Purchase:
                {
                    invoiceType.Table = "Purchase";
                    invoiceType.Table_Entry = "Purchase_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.RePurchase:
                {
                    invoiceType.Table = "RePurchase";
                    invoiceType.Table_Entry = "RePurchase_Entry";
                    invoiceType.TablePayment = "RePurchase_Payment";
                    break;
                }

            case AppStatics.Dealings.PurchaseQuote:
                {
                    invoiceType.Table = "PurchaseQuote";
                    invoiceType.Table_Entry = "PurchaseQuote_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.PurchaseQuoteRecieve:
                {
                    invoiceType.Table = "PurchaseQuoteRecieve";
                    invoiceType.Table_Entry = "PurchaseQuoteRecieve_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.PurchaseOrder:
                {
                    invoiceType.Table = "PurchaseOrder";
                    invoiceType.Table_Entry = "PurchaseOrder_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreRecieve:
                {
                    invoiceType.Table = "StoreRecieve";
                    invoiceType.Table_Entry = "StoreRecieve_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreIssue:
                {
                    invoiceType.Table = "StoreIssue";
                    invoiceType.Table_Entry = "StoreIssue_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StorePacking:
                {
                    invoiceType.Table = "StorePacking";
                    invoiceType.Table_Entry = "StorePacking_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreIN:
                {
                    invoiceType.Table = "StoreIN";
                    invoiceType.Table_Entry = "StoreIN_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreInTransfer:
                {
                    invoiceType.Table = "StoreInTransfer";
                    invoiceType.Table_Entry = "StoreInTransfer_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreOutTransfer:
                {
                    invoiceType.Table = "StoreOutTransfer";
                    invoiceType.Table_Entry = "StoreOutTransfer_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreOpening:
                {
                    invoiceType.Table = "StoreOpening";
                    invoiceType.Table_Entry = "StoreOpening_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.PurchaseConfirm:
                {
                    invoiceType.Table = "PurchaseConfirm";
                    invoiceType.Table_Entry = "PurchaseConfirm_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreTransferOrder:
                {
                    invoiceType.Table = "StoreTransferOrder";
                    invoiceType.Table_Entry = "StoreTransferOrder_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreSendOrder:
                {
                    invoiceType.Table = "StoreSendOrder";
                    invoiceType.Table_Entry = "StoreSendOrder_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.StorePackingOrder:
                {
                    invoiceType.Table = "StorePackingOrder";
                    invoiceType.Table_Entry = "StorePackingOrder_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StorePackingCancel:
                {
                    invoiceType.Table = "StorePackingCancel";
                    invoiceType.Table_Entry = "StorePackingCancel_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.Sale:
                {
                    invoiceType.TablePayment = "Sale_Payment";
                    invoiceType.Table = "Sale";
                    invoiceType.Table_Entry = "Sale_Entry";
                    break;
                }

            case AppStatics.Dealings.PosSale:
                {
                    invoiceType.TablePayment = "Sale_Payment";
                    invoiceType.Table = "Sale";
                    invoiceType.Table_Entry = "Sale_Entry";
                    break;
                }

            case AppStatics.Dealings.ReSale:
                {
                    invoiceType.Table = "ReSale";
                    invoiceType.Table_Entry = "ReSale_Entry";
                    invoiceType.TablePayment = "ReSale_Payment";
                    break;
                }

            case AppStatics.Dealings.SaleQoute:
                {
                    invoiceType.TablePayment = "Purchase_Payment";
                    invoiceType.Table = "SaleQoute";
                    invoiceType.Table_Entry = "SaleQoute_Entry";
                    invoiceType.TablePayment = "Purchase_Payment";
                    break;
                }

            case AppStatics.Dealings.SaleEstimate:
                {
                    invoiceType.Table = "SaleEstimate";
                    invoiceType.Table_Entry = "SaleEstimate_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.PosPendingHall:
                {
                    invoiceType.Table = "PosHall";
                    invoiceType.Table_Entry = "PosHall_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.PosPendingDelivery:
                {
                    invoiceType.Table = "PosPendingDelivery";
                    invoiceType.Table_Entry = "PosPendingDelivery_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.SaleOrder:
                {
                    invoiceType.Table = "SaleOrder";
                    invoiceType.Table_Entry = "SaleOrder_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreOut:
                {
                    invoiceType.Table = "StoreOut";
                    invoiceType.Table_Entry = "StoreOut_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreHalek:
                {
                    invoiceType.Table = "StoreHalek";
                    invoiceType.Table_Entry = "StoreHalek_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreCharity:
                {
                    invoiceType.Table = "StoreCharity";
                    invoiceType.Table_Entry = "StoreCharity_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.StoreConvert:
                {
                    invoiceType.Table = "StoreConvert";
                    invoiceType.Table_Entry = "StoreConvert_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.SaleConfirm:
                {
                    invoiceType.Table = "SaleConfirm";
                    invoiceType.Table_Entry = "SaleConfirm_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.RecieveConsignment:
                {
                    invoiceType.Table = "RecieveConsignment";
                    invoiceType.Table_Entry = "RecieveConsignment_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.ReturnConsignment:
                {
                    invoiceType.Table = "ReturnConsignment";
                    invoiceType.Table_Entry = "ReturnConsignment_Entry";
                    invoiceType.TablePayment = "Sale_Payment";
                    break;
                }

            case AppStatics.Dealings.CashSpend:
                {
                    invoiceType.Table = "Expenses";
                    invoiceType.Table_Entry = "Expenses_Entry";
                    invoiceType.TablePayment = "";
                    break;
                }
            case AppStatics.Dealings.CashIncome:
                {
                    invoiceType.Table = "Incomes";
                    invoiceType.Table_Entry = "Incomes_Entry";
                    invoiceType.TablePayment = "";
                    break;
                }
            case AppStatics.Dealings.CustRecieveMoney:
                {
                    invoiceType.Table = "Cash_Recieved";
                    invoiceType.Table_Entry = "Incomes_Entry";
                    invoiceType.TablePayment = "";
                    break;
                }
            case AppStatics.Dealings.CustPayMoeny:
                {
                    invoiceType.Table = "Cash_Paid";
                    break;
                }
        }

        return invoiceType;
    }
}

public class InvoiceinvoiceTypee
{
    public bool IsSale { get; set; }
    public bool ISBuy { get; set; }
    public string SerialMode { get; set; }
    public string UserPermission { get; set; }
    public string BillDealing { get; set; }
    public string BillDealinginvoiceTypee { get; set; }
    public string BillTrans { get; set; }
    public string BillInvoiceName { get; set; }
    public string Table { get; set; }
    public string Table_Entry { get; set; }
    public string TablePayment { get; set; }
    public bool ISCredit { get; set; }
    public bool ISDebit { get; set; }
    public bool IsInQty { get; set; }
    public bool HasBalance { get; set; }
    public bool HasCosting { get; set; }
    public bool ValidatePrice { get; set; }
    public bool UseCust { get; set; }
    public bool UseQuote { get; set; }
    public bool UseTitle { get; set; }
    public bool UseTransfer { get; set; }
    public bool UseStoreTrans { get; set; }
    public bool UseImportOrder { get; set; }
    public bool ShowPay { get; set; }
    public bool ShowDiscount { get; set; }
    public bool ShowTotal { get; set; }
    public bool LetSummaryOnly { get; set; }
    public bool ShowCustPrice { get; set; }
    public bool ShowCUstTransaction { get; set; }
    public bool IsRequiredcust { get; set; }
    public bool ShowPriceColumn { get; set; }
    public bool ValidateQty { get; set; }
    public bool UseAccountID { get; set; }
    public bool HasTransaction { get; set; }
    public bool ShowCustNum { get; set; }
    public bool UseStoreTransConfirm { get; set; }
}