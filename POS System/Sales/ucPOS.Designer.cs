namespace POS_System
{
    partial class ucPOS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.cellCartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellProductName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellPrice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellQuantity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellDiscount = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.txtReference = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2Chip();
            this.linkDiscount = new System.Windows.Forms.LinkLabel();
            this.btnViewBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnPercentage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCash = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusOnBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSearchMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnViewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtProductSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.panelProductContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
            this.pnlOption.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelProductContainer.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvPOS);
            this.panel1.Controls.Add(this.pnlOption);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(754, 57);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel1.Size = new System.Drawing.Size(454, 475);
            this.panel1.TabIndex = 6;
            // 
            // dgvPOS
            // 
            this.dgvPOS.AllowUserToAddRows = false;
            this.dgvPOS.AllowUserToDeleteRows = false;
            this.dgvPOS.AllowUserToResizeColumns = false;
            this.dgvPOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvPOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPOS.ColumnHeadersHeight = 35;
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellCartID,
            this.cellProductID,
            this.cellProductName,
            this.cellPrice,
            this.cellQuantity,
            this.cellDiscount,
            this.cellTotal,
            this.cellBatchNo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.NullValue = "...";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPOS.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPOS.EnableHeadersVisualStyles = false;
            this.dgvPOS.GridColor = System.Drawing.Color.White;
            this.dgvPOS.Location = new System.Drawing.Point(5, 45);
            this.dgvPOS.MultiSelect = false;
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.ReadOnly = true;
            this.dgvPOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPOS.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPOS.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPOS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPOS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPOS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgvPOS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dgvPOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.RowTemplate.DividerHeight = 1;
            this.dgvPOS.RowTemplate.Height = 40;
            this.dgvPOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOS.ShowCellToolTips = false;
            this.dgvPOS.Size = new System.Drawing.Size(444, 197);
            this.dgvPOS.TabIndex = 310;
            this.dgvPOS.TabStop = false;
            this.dgvPOS.DataSourceChanged += new System.EventHandler(this.dgvPOS_DataSourceChanged);
            this.dgvPOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOS_CellContentClick);
            this.dgvPOS.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPOS_RowsRemoved);
            this.dgvPOS.SelectionChanged += new System.EventHandler(this.dgvPOS_SelectionChanged);
            // 
            // cellCartID
            // 
            this.cellCartID.DataPropertyName = "cart_id";
            this.cellCartID.HeaderText = "#";
            this.cellCartID.Name = "cellCartID";
            this.cellCartID.ReadOnly = true;
            this.cellCartID.Visible = false;
            // 
            // cellProductID
            // 
            this.cellProductID.DataPropertyName = "item_id";
            this.cellProductID.HeaderText = "productID";
            this.cellProductID.Name = "cellProductID";
            this.cellProductID.ReadOnly = true;
            this.cellProductID.Visible = false;
            // 
            // cellProductName
            // 
            this.cellProductName.DataPropertyName = "itm_name";
            this.cellProductName.FillWeight = 150F;
            this.cellProductName.HeaderText = "Product";
            this.cellProductName.Name = "cellProductName";
            this.cellProductName.ReadOnly = true;
            this.cellProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellProductName.Width = 148;
            // 
            // cellPrice
            // 
            this.cellPrice.DataPropertyName = "item_price";
            this.cellPrice.HeaderText = "Price";
            this.cellPrice.Name = "cellPrice";
            this.cellPrice.ReadOnly = true;
            this.cellPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellPrice.Width = 99;
            // 
            // cellQuantity
            // 
            this.cellQuantity.DataPropertyName = "item_quantity";
            this.cellQuantity.FillWeight = 60F;
            this.cellQuantity.HeaderText = "Qty";
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ReadOnly = true;
            this.cellQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellQuantity.Width = 49;
            // 
            // cellDiscount
            // 
            this.cellDiscount.DataPropertyName = "item_discount";
            this.cellDiscount.FillWeight = 70F;
            this.cellDiscount.HeaderText = "Disc X 1";
            this.cellDiscount.Name = "cellDiscount";
            this.cellDiscount.ReadOnly = true;
            this.cellDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellDiscount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellDiscount.Width = 69;
            // 
            // cellTotal
            // 
            this.cellTotal.DataPropertyName = "total";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.cellTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.cellTotal.FillWeight = 80F;
            this.cellTotal.HeaderText = "Line Total";
            this.cellTotal.Name = "cellTotal";
            this.cellTotal.ReadOnly = true;
            this.cellTotal.Width = 79;
            // 
            // cellBatchNo
            // 
            this.cellBatchNo.DataPropertyName = "batch_no";
            this.cellBatchNo.HeaderText = "Batch No";
            this.cellBatchNo.Name = "cellBatchNo";
            this.cellBatchNo.ReadOnly = true;
            this.cellBatchNo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "unit_cost";
            this.Column1.HeaderText = "Unit Cost";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "line_cost";
            dataGridViewCellStyle4.Format = "N2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Line Cost";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "profit";
            dataGridViewCellStyle5.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Line Profit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "indirect_profit";
            dataGridViewCellStyle6.Format = "N2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Indirect Profit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.txtReference);
            this.pnlOption.Controls.Add(this.label1);
            this.pnlOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOption.Location = new System.Drawing.Point(5, 0);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(444, 45);
            this.pnlOption.TabIndex = 311;
            // 
            // txtReference
            // 
            this.txtReference.Animated = true;
            this.txtReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtReference.BorderRadius = 5;
            this.txtReference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReference.DefaultText = "";
            this.txtReference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.DisabledState.Parent = this.txtReference;
            this.txtReference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.FocusedState.Parent = this.txtReference;
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReference.HoverState.Parent = this.txtReference;
            this.txtReference.Location = new System.Drawing.Point(102, 6);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4);
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.PlaceholderText = "Reference";
            this.txtReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReference.SelectedText = "";
            this.txtReference.ShadowDecoration.Parent = this.txtReference;
            this.txtReference.Size = new System.Drawing.Size(333, 33);
            this.txtReference.TabIndex = 6;
            this.txtReference.Tag = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reference";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.linkDiscount);
            this.panel4.Controls.Add(this.btnViewBill);
            this.panel4.Controls.Add(this.btnPercentage);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 169);
            this.panel4.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BorderRadius = 10;
            this.lblTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(153, 114);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ShadowDecoration.Parent = this.lblTotal;
            this.lblTotal.Size = new System.Drawing.Size(288, 49);
            this.lblTotal.TabIndex = 313;
            this.lblTotal.Text = "Rs. 0";
            this.lblTotal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.lblTotal.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // linkDiscount
            // 
            this.linkDiscount.AutoSize = true;
            this.linkDiscount.Font = new System.Drawing.Font("Calibri", 12F);
            this.linkDiscount.Location = new System.Drawing.Point(149, 74);
            this.linkDiscount.Name = "linkDiscount";
            this.linkDiscount.Size = new System.Drawing.Size(106, 19);
            this.linkDiscount.TabIndex = 348;
            this.linkDiscount.TabStop = true;
            this.linkDiscount.Text = "Discount :   Rs.";
            this.linkDiscount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiscount_LinkClicked);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Animated = true;
            this.btnViewBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewBill.BorderRadius = 5;
            this.btnViewBill.BorderThickness = 1;
            this.btnViewBill.CheckedState.Parent = this.btnViewBill;
            this.btnViewBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBill.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewBill.CustomImages.Parent = this.btnViewBill;
            this.btnViewBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewBill.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewBill.ForeColor = System.Drawing.Color.White;
            this.btnViewBill.HoverState.Parent = this.btnViewBill;
            this.btnViewBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewBill.ImageSize = new System.Drawing.Size(18, 18);
            this.btnViewBill.Location = new System.Drawing.Point(3, 114);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.ShadowDecoration.Parent = this.btnViewBill;
            this.btnViewBill.Size = new System.Drawing.Size(144, 49);
            this.btnViewBill.TabIndex = 346;
            this.btnViewBill.Tag = "1";
            this.btnViewBill.Text = "DETAILED BILL";
            this.btnViewBill.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.Animated = true;
            this.btnPercentage.CheckedState.Parent = this.btnPercentage;
            this.btnPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPercentage.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPercentage.CustomImages.Parent = this.btnPercentage;
            this.btnPercentage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPercentage.ForeColor = System.Drawing.Color.White;
            this.btnPercentage.HoverState.Parent = this.btnPercentage;
            this.btnPercentage.Image = ((System.Drawing.Image)(resources.GetObject("btnPercentage.Image")));
            this.btnPercentage.Location = new System.Drawing.Point(386, 65);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPercentage.ShadowDecoration.Parent = this.btnPercentage;
            this.btnPercentage.Size = new System.Drawing.Size(37, 37);
            this.btnPercentage.TabIndex = 347;
            this.guna2HtmlToolTip1.SetToolTip(this.btnPercentage, "Find Discount");
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Animated = true;
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtDiscount.BorderRadius = 6;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(263, 65);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 1;
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(116, 37);
            this.txtDiscount.TabIndex = 320;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Animated = true;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtTotal.BorderRadius = 6;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "0";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(263, 10);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionStart = 1;
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(162, 37);
            this.txtTotal.TabIndex = 320;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 322;
            this.label3.Text = "Sub Total :   Rs.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnCash);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 59);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(1, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(142, 48);
            this.btnCancel.TabIndex = 312;
            this.btnCancel.Text = "CLEAR";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCash
            // 
            this.btnCash.Animated = true;
            this.btnCash.BorderRadius = 10;
            this.btnCash.CheckedState.Parent = this.btnCash;
            this.btnCash.CustomImages.Parent = this.btnCash;
            this.btnCash.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.HoverState.Parent = this.btnCash;
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCash.Location = new System.Drawing.Point(307, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.ShadowDecoration.Parent = this.btnCash;
            this.btnCash.Size = new System.Drawing.Size(134, 51);
            this.btnCash.TabIndex = 312;
            this.btnCash.Text = "CASH";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Animated = true;
            this.btnPayment.BorderRadius = 10;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Location = new System.Drawing.Point(147, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(153, 51);
            this.btnPayment.TabIndex = 312;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(246)))));
            this.pnlTop.Controls.Add(this.toolStrip1);
            this.pnlTop.Controls.Add(this.cmbSearchMethod);
            this.pnlTop.Controls.Add(this.btnAddCustomer);
            this.pnlTop.Controls.Add(this.btnViewCustomer);
            this.pnlTop.Controls.Add(this.btnCustomer);
            this.pnlTop.Controls.Add(this.txtProductSearch);
            this.pnlTop.Controls.Add(this.lblPeople);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10, 0, 0, 2);
            this.pnlTop.Size = new System.Drawing.Size(1208, 57);
            this.pnlTop.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(10, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 25);
            this.toolStrip1.TabIndex = 367;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveToolStripMenuItem,
            this.focusOnBarcodeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.fileSaveToolStripMenuItem.Text = "File Save";
            // 
            // focusOnBarcodeToolStripMenuItem
            // 
            this.focusOnBarcodeToolStripMenuItem.Name = "focusOnBarcodeToolStripMenuItem";
            this.focusOnBarcodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.focusOnBarcodeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.focusOnBarcodeToolStripMenuItem.Text = "Focus On Barcode";
            this.focusOnBarcodeToolStripMenuItem.Click += new System.EventHandler(this.focusOnBarcodeToolStripMenuItem_Click);
            // 
            // cmbSearchMethod
            // 
            this.cmbSearchMethod.Animated = true;
            this.cmbSearchMethod.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchMethod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbSearchMethod.BorderRadius = 5;
            this.cmbSearchMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchMethod.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSearchMethod.FocusedState.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSearchMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearchMethod.FormattingEnabled = true;
            this.cmbSearchMethod.HoverState.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.ItemHeight = 35;
            this.cmbSearchMethod.Items.AddRange(new object[] {
            "Item Name",
            "Item Code"});
            this.cmbSearchMethod.ItemsAppearance.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.Location = new System.Drawing.Point(8, 9);
            this.cmbSearchMethod.Name = "cmbSearchMethod";
            this.cmbSearchMethod.ShadowDecoration.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.Size = new System.Drawing.Size(153, 41);
            this.cmbSearchMethod.StartIndex = 0;
            this.cmbSearchMethod.TabIndex = 348;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.Animated = true;
            this.btnAddCustomer.CheckedState.Parent = this.btnAddCustomer;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCustomer.CustomImages.Parent = this.btnAddCustomer;
            this.btnAddCustomer.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.HoverState.Parent = this.btnAddCustomer;
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.Location = new System.Drawing.Point(1160, 8);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCustomer.ShadowDecoration.Parent = this.btnAddCustomer;
            this.btnAddCustomer.Size = new System.Drawing.Size(40, 40);
            this.btnAddCustomer.TabIndex = 347;
            this.guna2HtmlToolTip1.SetToolTip(this.btnAddCustomer, "Add New Customer");
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCustomer.Animated = true;
            this.btnViewCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewCustomer.BorderRadius = 5;
            this.btnViewCustomer.BorderThickness = 1;
            this.btnViewCustomer.CheckedState.Parent = this.btnViewCustomer;
            this.btnViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustomer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewCustomer.CustomImages.Parent = this.btnViewCustomer;
            this.btnViewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnViewCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomer.HoverState.Parent = this.btnViewCustomer;
            this.btnViewCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewCustomer.ImageSize = new System.Drawing.Size(18, 18);
            this.btnViewCustomer.Location = new System.Drawing.Point(754, 10);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.ShadowDecoration.Parent = this.btnViewCustomer;
            this.btnViewCustomer.Size = new System.Drawing.Size(67, 37);
            this.btnViewCustomer.TabIndex = 346;
            this.btnViewCustomer.Tag = "1";
            this.btnViewCustomer.Text = "VIEW";
            this.btnViewCustomer.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomer.Animated = true;
            this.btnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCustomer.BorderRadius = 5;
            this.btnCustomer.BorderThickness = 1;
            this.btnCustomer.CheckedState.Parent = this.btnCustomer;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCustomer.CustomImages.Parent = this.btnCustomer;
            this.btnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.Parent = this.btnCustomer;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCustomer.Location = new System.Drawing.Point(827, 10);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ShadowDecoration.Parent = this.btnCustomer;
            this.btnCustomer.Size = new System.Drawing.Size(327, 37);
            this.btnCustomer.TabIndex = 346;
            this.btnCustomer.Tag = "1";
            this.btnCustomer.Text = "walk in client";
            this.btnCustomer.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCustomer.TextChanged += new System.EventHandler(this.btnCustomer_TextChanged);
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductSearch.Animated = true;
            this.txtProductSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtProductSearch.BorderRadius = 10;
            this.txtProductSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductSearch.DefaultText = "";
            this.txtProductSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.DisabledState.Parent = this.txtProductSearch;
            this.txtProductSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.FocusedState.Parent = this.txtProductSearch;
            this.txtProductSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductSearch.HoverState.Parent = this.txtProductSearch;
            this.txtProductSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtProductSearch.IconLeft")));
            this.txtProductSearch.Location = new System.Drawing.Point(167, 8);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.PasswordChar = '\0';
            this.txtProductSearch.PlaceholderText = "Item Code / Item Name";
            this.txtProductSearch.SelectedText = "";
            this.txtProductSearch.ShadowDecoration.Parent = this.txtProductSearch;
            this.txtProductSearch.Size = new System.Drawing.Size(340, 42);
            this.txtProductSearch.TabIndex = 320;
            this.txtProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduct_KeyDown);
            // 
            // lblPeople
            // 
            this.lblPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeople.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeople.Location = new System.Drawing.Point(649, 19);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(105, 23);
            this.lblPeople.TabIndex = 5;
            this.lblPeople.Text = "Your Customer";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelProductContainer
            // 
            this.panelProductContainer.AutoScroll = true;
            this.panelProductContainer.Controls.Add(this.lblMessage);
            this.panelProductContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductContainer.Location = new System.Drawing.Point(185, 57);
            this.panelProductContainer.Name = "panelProductContainer";
            this.panelProductContainer.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.panelProductContainer.Size = new System.Drawing.Size(569, 475);
            this.panelProductContainer.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Crimson;
            this.lblMessage.Location = new System.Drawing.Point(18, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(474, 66);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "NO ITEM FOUND";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.Controls.Add(this.btnMenu);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 57);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(8, 10, 0, 0);
            this.pnlSideBar.Size = new System.Drawing.Size(185, 475);
            this.pnlSideBar.TabIndex = 9;
            this.pnlSideBar.WrapContents = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Animated = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BorderRadius = 5;
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenu.Checked = true;
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.btnMenu.CustomImages.Parent = this.btnMenu;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Location = new System.Drawing.Point(11, 13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(150, 47);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Tag = "Featured";
            this.btnMenu.Text = "Featured";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ucPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProductContainer);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucPOS";
            this.Size = new System.Drawing.Size(1208, 532);
            this.Load += new System.EventHandler(this.ucPOS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelProductContainer.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel panelProductContainer;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2TextBox txtProductSearch;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel pnlSideBar;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCustomer;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPercentage;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Chip lblTotal;
        private System.Windows.Forms.LinkLabel linkDiscount;
        private Guna.UI2.WinForms.Guna2Button btnViewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnViewBill;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchMethod;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusOnBarcodeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellCartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellProductID;
        private System.Windows.Forms.DataGridViewLinkColumn cellProductName;
        private System.Windows.Forms.DataGridViewLinkColumn cellPrice;
        private System.Windows.Forms.DataGridViewLinkColumn cellQuantity;
        private System.Windows.Forms.DataGridViewLinkColumn cellDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
