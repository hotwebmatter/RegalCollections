using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RegalCollections
{
    class InvoiceFile
    {
        public void WriteFile(InvoiceCollection invoices, StreamWriter outfile)
        {
            try
            {
                foreach (Invoice anInvoice in invoices.AllInvoices)
                {
                    string result;
                    result = ($"{anInvoice.number},{anInvoice.custID},");
                    result += (anInvoice.date.ToShortDateString());
                    result += ($",{anInvoice.salesAmount}");
                    outfile.WriteLine(result);
                    MessageBox.Show($"Attempting to write to file:\n{result}");
                }
                
                MessageBox.Show("Wrote invoices to 'invoices.txt' file.\n");
            }
            catch
            {
                MessageBox.Show("Failed to create file");
            }
        }
        public void ReadFile(InvoiceCollection invoices)
        {
            StreamReader infile;
            char delimiter = ',';
            string line;
            string[] fields = new string[4]; // unnecessary assignment of value
            if (File.Exists("invoices.txt"))
                MessageBox.Show("File 'invoices.txt' exists.\n");
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
