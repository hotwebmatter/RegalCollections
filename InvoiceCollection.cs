using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegalCollections
{
    public class InvoiceCollection
    {
        // dictionary property
        Dictionary<int, Invoice> invoiceList = new Dictionary<int, Invoice>();

        // value collection method (accessor)
        public Dictionary<int, Invoice>.ValueCollection AllInvoices
        {
            get { return invoiceList.Values; }
        }

        // add and remove methods
        public void AddInvoice(Invoice invoice)
        {
            invoiceList.Add(invoice.number, invoice);
        }
        public void RemoveInvoice(int number)
        {
            invoiceList.Remove(number);
        }
    }
}
