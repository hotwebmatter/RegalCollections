namespace RegalCollections
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.cboInvoice = new System.Windows.Forms.ComboBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(53, 57);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(121, 20);
            this.lblInvoice.TabIndex = 1;
            this.lblInvoice.Text = "Invoice number:";
            // 
            // cboInvoice
            // 
            this.cboInvoice.FormattingEnabled = true;
            this.cboInvoice.Location = new System.Drawing.Point(211, 54);
            this.cboInvoice.Name = "cboInvoice";
            this.cboInvoice.Size = new System.Drawing.Size(280, 28);
            this.cboInvoice.TabIndex = 2;
            this.cboInvoice.SelectedIndexChanged += new System.EventHandler(this.CboInvoice_SelectedIndexChanged);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(53, 107);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(103, 20);
            this.lblCustID.TabIndex = 3;
            this.lblCustID.Text = "Customer ID:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(211, 106);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(280, 26);
            this.txtCustID.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(53, 157);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(53, 207);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(211, 206);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(280, 26);
            this.txtAmount.TabIndex = 8;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnFind);
            this.grpSearch.Controls.Add(this.txtFind);
            this.grpSearch.Controls.Add(this.lblFind);
            this.grpSearch.Location = new System.Drawing.Point(57, 264);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(434, 156);
            this.grpSearch.TabIndex = 9;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(25, 47);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(109, 20);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find invoice #:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(154, 40);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(262, 26);
            this.txtFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(154, 87);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(262, 44);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Invoice";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(547, 54);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(225, 58);
            this.btnAddSave.TabIndex = 10;
            this.btnAddSave.Text = "Add";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(547, 130);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(225, 58);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(547, 206);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(225, 58);
            this.btnTotal.TabIndex = 12;
            this.btnTotal.Text = "Total Invoices";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(547, 282);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(225, 58);
            this.btnDisplayAll.TabIndex = 13;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(211, 157);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(280, 26);
            this.dtpDate.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.cboInvoice);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Regal Invoices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.ComboBox cboInvoice;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

