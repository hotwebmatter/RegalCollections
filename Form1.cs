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
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
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

        private void CboInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoice anInvoice;
            anInvoice = anInvoiceCollection.FindInvoice(int.Parse(cboInvoice.Text));
            if (anInvoice == null)
            {
                MessageBox.Show("Not found", "Error");
            }
            else
            {
                txtCustID.Text = anInvoice.custID.ToString();
                dtpDate.Value = anInvoice.date;
                txtAmount.Text = anInvoice.salesAmount.ToString("c");
            }
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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Text == "Cancel")
            {
                btnAddSave.Text = "Add";
                btnRemove.Text = "Remove";
                btnFind.Enabled = true;
                FillCombo();
            }
            else
            {
                DialogResult dlgResults;
                dlgResults = MessageBox.Show("Remove invoice", "Delete", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlgResults == System.Windows.Forms.DialogResult.Yes)
                {
                    anInvoiceCollection.RemoveInvoice(int.Parse(cboInvoice.Text));
                    cboInvoice.Text = string.Empty;
                    txtCustID.Clear();
                    txtAmount.Clear();
                    FillCombo();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResults;
            dlgResults = MessageBox.Show("Exit", "Exit", MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlgResults == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                anInvoiceFile.WriteFile(anInvoiceCollection);
            }
        }
    }
}
