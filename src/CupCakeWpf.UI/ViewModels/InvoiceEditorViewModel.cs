using CupCakeWpf.UI.ViewModels.Interfaces;
using System.Collections.Generic;

namespace CupCakeWpf.UI.ViewModels
{
    public class InvoiceEditorViewModel : ViewModelBase, IInvoiceEditorViewModel
    {
        public InvoiceEditorViewModel()
        {
            InvoiceItems = getInvoiceItems();
        }

        private List<InvoiceItem> getInvoiceItems()
        {
            return new List<InvoiceItem>()
            {
                 new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 },
                 new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 },
                 new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 }
            };
        }

        public List<InvoiceItem> InvoiceItems { get; set; }

    }


    public class Invoice
    {
        public string Code { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTax { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }

    public class InvoiceItem
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class DataService
    {
        public static void GetInvoices()
        {
            var invoice = new Invoice()
            {
                Code = "Code1",
                CustomerName = "Customer1",
                TotalAmount = 21822,
                TotalTax = 221,
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 },
                    new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 },
                    new InvoiceItem(){ Name ="Name1", Quantity =10, TaxRate =8, UnitPrice = 22, TotalAmount = 2200 }
                }
            };
        }
    }
}
