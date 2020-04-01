using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegalCollections
{
    public class InvoiceCollection
    {
        // dictionary
        Dictionary<int, Invoice> invoiceList = new Dictionary<int, Invoice>();

        // value collection
        public Dictionary<int, Invoice>.ValueCollection AllInvoices
        {
            get { return invoiceList.Values; }
        }
    }
}
