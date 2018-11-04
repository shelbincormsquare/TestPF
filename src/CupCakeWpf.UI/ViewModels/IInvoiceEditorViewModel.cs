using System.Collections.Generic;

namespace CupCakeWpf.UI.ViewModels
{
    public interface IInvoiceEditorViewModel
    {
        List<InvoiceItem> InvoiceItems { get; set; }
    }
}