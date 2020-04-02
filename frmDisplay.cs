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
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        public InvoiceCollection aCollection = new InvoiceCollection();

        private void FrmDisplay_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = aCollection.ToString();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
