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

        private void Form1_Load(object sender, EventArgs e)
        {
            anInvoiceFile.ReadFile(anInvoiceCollection);

            ReadOnlyInputs(true);
            FillCombo();
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

        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            if (btnAddSave.Text == "Add")
            {
                ReadOnlyInputs(false);
                dtpDate.Enabled = true;
                btnAddSave.Text = "Save";
                btnRemove.Text = "Cancel";
                cboInvoice.Text = string.Empty;
                txtCustID.Clear();
                txtAmount.Clear();
                cboInvoice.Focus();
            }
            else
            {
                try
                {
                    btnRemove.Text = "Remove";
                    if (txtCustID.Text != string.Empty && txtAmount.Text != string.Empty
                        && cboInvoice.Text != string.Empty && dtpDate.Text != string.Empty)
                    {
                        Invoice newInvoice = new Invoice();
                        newInvoice.number = int.Parse(cboInvoice.Text);
                        newInvoice.custID = int.Parse(txtCustID.Text);
                        newInvoice.date = dtpDate.Value;
                        newInvoice.salesAmount = double.Parse(txtAmount.Text);
                        anInvoiceCollection.AddInvoice(newInvoice);
                        FillCombo();
                        cboInvoice.Text = string.Empty;
                        txtCustID.Text = string.Empty;
                        txtAmount.Text = string.Empty;

                        ReadOnlyInputs(true);
                        dtpDate.Enabled = true;
                        btnAddSave.Text = "Add";
                    }
                    else
                    {
                        MessageBox.Show("Data missing", "Error");
                        btnAddSave.Text = "Save";
                        btnRemove.Text = "Cancel";
                    }
                }
                catch
                {
                    MessageBox.Show("Duplicate number", "Error");
                    btnAddSave.Text = "Save";
                    btnRemove.Text = "Cancel";
                }
            }
        }
    }
}
