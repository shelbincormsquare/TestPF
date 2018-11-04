using System.Collections.Generic;

namespace CupCakeWpf.UI.ViewModels.Interfaces
{
    public interface IInvoiceEditorViewModel
    {
        List<InvoiceItem> InvoiceItems { get; set; }
    }
}