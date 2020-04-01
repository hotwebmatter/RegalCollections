using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegalCollections
{
    class InvoiceFile
    {
        public void WriteFile(InvoiceCollection invoices)
        {
            StreamWriter outfile;
            outfile = File.CreateText("invoices.txt");
            foreach (Invoice anInvoice in invoices.AllInvoices)
            {
                outfile.Write(anInvoice.number);
                outfile.Write(",");
                outfile.Write(anInvoice.custID);
                outfile.Write(",");
                outfile.Write(anInvoice.date.ToShortDateString());
                outfile.Write(",");
                outfile.Write(anInvoice.salesAmount);
            }
        }
        public void ReadFile(InvoiceCollection invoices)
        {
            StreamReader infile;
            char delimiter = ',';
            string line;
            string[] fields = new string[4]; // unnecessary assignment of value
            if (File.Exists("invoices.txt"))
            {
                infile = File.OpenText("invoices.txt");
                while (!infile.EndOfStream)
                {
                    line = infile.ReadLine();
                    fields = line.Split(delimiter);
                    Invoice anInvoice = new Invoice();
                    anInvoice.number = int.Parse(fields[0]);
                    anInvoice.custID = int.Parse(fields[1]);
                    anInvoice.date = DateTime.Parse(fields[2]);
                    anInvoice.salesAmount = double.Parse(fields[3]);
                    invoices.AddInvoice(anInvoice);
                }
                infile.Close();
            }
        }
    }
}
