using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegalCollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // instantiate collection and file
        private readonly InvoiceCollection anInvoiceCollection = new InvoiceCollection();
        private readonly InvoiceFile anInvoiceFile = new InvoiceFile();
        private void FillCombo()
        {
            // fill combo box with invoice numbers
            cboInvoice.Items.Clear();
            foreach (Invoice invoice in anInvoiceCollection.AllInvoices)
            {
                cboInvoice.Items.Add(invoice.number);
                cboInvoice.Text = $"{invoice.number}";
            }
        }

        private void ReadOnlyInputs(bool bln)
        {
            txtCustID.ReadOnly = bln;
            dtpDate.Enabled = bln;
            txtAmount.ReadOnly = bln;
            btnFind.Enabled = bln;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // TODO: Prompt user to confirm exit
        }
    }
}
