namespace POS_System
{
    partial class ucNewPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNewPurchaseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.txtRefrenceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPurchseDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.cellItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellCartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellItem = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellPrice = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellUnitTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSearchMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPurchasTotalAmount = new Guna.UI2.WinForms.Guna2Chip();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusOnBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaTooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.linkSupplier = new System.Windows.Forms.LinkLabel();
            this.btnPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewCheque = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaymentHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnMakePayment = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Animated = true;
            this.txtBarcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtBarcode.BorderRadius = 5;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.DisabledState.Parent = this.txtBarcode;
            this.txtBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.FocusedState.Parent = this.txtBarcode;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.txtBarcode.ForeColor = System.Drawing.Color.White;
            this.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.HoverState.Parent = this.txtBarcode;
            this.txtBarcode.Location = new System.Drawing.Point(156, 36);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBarcode.PlaceholderText = "";
            this.txtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.ShadowDecoration.Parent = this.txtBarcode;
            this.txtBarcode.Size = new System.Drawing.Size(475, 45);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Tag = "";
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.Enter += new System.EventHandler(this.txtBarcode_Enter);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Search (Ctrl + F)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Animated = true;
            this.btnAddSupplier.CheckedState.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSupplier.CustomImages.Parent = this.btnAddSupplier;
            this.btnAddSupplier.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.HoverState.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Image")));
            this.btnAddSupplier.Location = new System.Drawing.Point(382, 16);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddSupplier.ShadowDecoration.Parent = this.btnAddSupplier;
            this.btnAddSupplier.Size = new System.Drawing.Size(35, 35);
            this.btnAddSupplier.TabIndex = 355;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Animated = true;
            this.btnSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.BorderRadius = 5;
            this.btnSupplier.BorderThickness = 1;
            this.btnSupplier.CheckedState.Parent = this.btnSupplier;
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.CustomImages.Parent = this.btnSupplier;
            this.btnSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.HoverState.Parent = this.btnSupplier;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSupplier.Location = new System.Drawing.Point(92, 15);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.ShadowDecoration.Parent = this.btnSupplier;
            this.btnSupplier.Size = new System.Drawing.Size(284, 37);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Tag = "0";
            this.btnSupplier.Text = "select your supplier";
            this.btnSupplier.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSupplier.TextChanged += new System.EventHandler(this.btnSupplier_TextChanged);
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // txtRefrenceNo
            // 
            this.txtRefrenceNo.Animated = true;
            this.txtRefrenceNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.BorderRadius = 6;
            this.txtRefrenceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefrenceNo.DefaultText = "0";
            this.txtRefrenceNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefrenceNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRefrenceNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefrenceNo.DisabledState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefrenceNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.FocusedState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRefrenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRefrenceNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.HoverState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Location = new System.Drawing.Point(523, 15);
            this.txtRefrenceNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtRefrenceNo.Name = "txtRefrenceNo";
            this.txtRefrenceNo.PasswordChar = '\0';
            this.txtRefrenceNo.PlaceholderText = "";
            this.txtRefrenceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRefrenceNo.SelectedText = "";
            this.txtRefrenceNo.SelectionStart = 1;
            this.txtRefrenceNo.ShadowDecoration.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Size = new System.Drawing.Size(128, 37);
            this.txtRefrenceNo.TabIndex = 1;
            this.txtRefrenceNo.TextChanged += new System.EventHandler(this.txtRefrenceNo_TextChanged);
            this.txtRefrenceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRefrenceNo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(429, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 356;
            this.label9.Text = "Refrence No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpPurchseDate
            // 
            this.dtpPurchseDate.Animated = true;
            this.dtpPurchseDate.BorderRadius = 8;
            this.dtpPurchseDate.CheckedState.Parent = this.dtpPurchseDate;
            this.dtpPurchseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpPurchseDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpPurchseDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpPurchseDate.ForeColor = System.Drawing.Color.White;
            this.dtpPurchseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPurchseDate.HoverState.Parent = this.dtpPurchseDate;
            this.dtpPurchseDate.Location = new System.Drawing.Point(706, 14);
            this.dtpPurchseDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPurchseDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPurchseDate.Name = "dtpPurchseDate";
            this.dtpPurchseDate.ShadowDecoration.Parent = this.dtpPurchseDate;
            this.dtpPurchseDate.Size = new System.Drawing.Size(152, 39);
            this.dtpPurchseDate.TabIndex = 2;
            this.dtpPurchseDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpPurchseDate.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 358;
            this.label8.Text = "Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(1, 60);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1133, 10);
            this.guna2Separator1.TabIndex = 360;
            // 
            // dgvGrid
            // 
            this.dgvGrid.AllowUserToAddRows = false;
            this.dgvGrid.AllowUserToDeleteRows = false;
            this.dgvGrid.AllowUserToResizeColumns = false;
            this.dgvGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvGrid.ColumnHeadersHeight = 40;
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellItemID,
            this.cellCartID,
            this.cellItem,
            this.cellPrice,
            this.Column2,
            this.cellQuantity,
            this.cellDiscount,
            this.cellUnitTotal,
            this.Column8,
            this.cellBatchNo,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.cellRemove});
            this.dgvGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrid.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvGrid.EnableHeadersVisualStyles = false;
            this.dgvGrid.GridColor = System.Drawing.Color.White;
            this.dgvGrid.Location = new System.Drawing.Point(20, 92);
            this.dgvGrid.MultiSelect = false;
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.ReadOnly = true;
            this.dgvGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvGrid.RowHeadersVisible = false;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGrid.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrid.RowTemplate.DividerHeight = 1;
            this.dgvGrid.RowTemplate.Height = 35;
            this.dgvGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrid.ShowCellToolTips = false;
            this.dgvGrid.Size = new System.Drawing.Size(1084, 414);
            this.dgvGrid.TabIndex = 363;
            this.dgvGrid.TabStop = false;
            this.dgvGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // cellItemID
            // 
            this.cellItemID.DataPropertyName = "item_id";
            this.cellItemID.HeaderText = "item_id";
            this.cellItemID.Name = "cellItemID";
            this.cellItemID.ReadOnly = true;
            this.cellItemID.Visible = false;
            // 
            // cellCartID
            // 
            this.cellCartID.DataPropertyName = "cart_id";
            this.cellCartID.FillWeight = 20F;
            this.cellCartID.HeaderText = "#";
            this.cellCartID.Name = "cellCartID";
            this.cellCartID.ReadOnly = true;
            this.cellCartID.Visible = false;
            // 
            // cellItem
            // 
            this.cellItem.DataPropertyName = "itm_name";
            this.cellItem.FillWeight = 120F;
            this.cellItem.HeaderText = "Item";
            this.cellItem.Name = "cellItem";
            this.cellItem.ReadOnly = true;
            this.cellItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cellPrice
            // 
            this.cellPrice.DataPropertyName = "cost";
            dataGridViewCellStyle27.Format = "N2";
            this.cellPrice.DefaultCellStyle = dataGridViewCellStyle27;
            this.cellPrice.FillWeight = 70F;
            this.cellPrice.HeaderText = "Price";
            this.cellPrice.Name = "cellPrice";
            this.cellPrice.ReadOnly = true;
            this.cellPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "indirect_cost";
            dataGridViewCellStyle28.Format = "N2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle28;
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "Item Cost";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cellQuantity
            // 
            this.cellQuantity.DataPropertyName = "quantity";
            dataGridViewCellStyle29.Format = "N2";
            this.cellQuantity.DefaultCellStyle = dataGridViewCellStyle29;
            this.cellQuantity.FillWeight = 55F;
            this.cellQuantity.HeaderText = "Qty";
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ReadOnly = true;
            // 
            // cellDiscount
            // 
            this.cellDiscount.DataPropertyName = "discount";
            dataGridViewCellStyle30.Format = "N2";
            this.cellDiscount.DefaultCellStyle = dataGridViewCellStyle30;
            this.cellDiscount.FillWeight = 60F;
            this.cellDiscount.HeaderText = "TL.Disc";
            this.cellDiscount.Name = "cellDiscount";
            this.cellDiscount.ReadOnly = true;
            // 
            // cellUnitTotal
            // 
            this.cellUnitTotal.DataPropertyName = "total";
            dataGridViewCellStyle31.Format = "N2";
            this.cellUnitTotal.DefaultCellStyle = dataGridViewCellStyle31;
            this.cellUnitTotal.FillWeight = 80F;
            this.cellUnitTotal.HeaderText = "Total";
            this.cellUnitTotal.Name = "cellUnitTotal";
            this.cellUnitTotal.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "indirect_total";
            dataGridViewCellStyle32.Format = "N2";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle32;
            this.Column8.FillWeight = 70F;
            this.Column8.HeaderText = "Cost Total";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // cellBatchNo
            // 
            this.cellBatchNo.DataPropertyName = "batch_no";
            this.cellBatchNo.HeaderText = "Batch";
            this.cellBatchNo.Name = "cellBatchNo";
            this.cellBatchNo.ReadOnly = true;
            this.cellBatchNo.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sale_price";
            dataGridViewCellStyle33.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle33;
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "Sale Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "whole_sale_price";
            this.Column4.HeaderText = "Whole S/P";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "retail_price";
            this.Column5.HeaderText = "Retail Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mf_date";
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "MFG";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "exp_date";
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "EXP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // cellRemove
            // 
            this.cellRemove.FillWeight = 40F;
            this.cellRemove.HeaderText = "Remove";
            this.cellRemove.Name = "cellRemove";
            this.cellRemove.ReadOnly = true;
            this.cellRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellRemove.Text = "Delete";
            this.cellRemove.UseColumnTextForLinkValue = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Animated = true;
            this.btnComplete.BorderRadius = 10;
            this.btnComplete.CheckedState.Parent = this.btnComplete;
            this.btnComplete.CustomImages.Parent = this.btnComplete;
            this.btnComplete.FillColor = System.Drawing.Color.SeaGreen;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.HoverState.Parent = this.btnComplete;
            this.btnComplete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnComplete.Location = new System.Drawing.Point(865, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.ShadowDecoration.Parent = this.btnComplete;
            this.btnComplete.Size = new System.Drawing.Size(184, 51);
            this.btnComplete.TabIndex = 324;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(897, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 18);
            this.label21.TabIndex = 351;
            this.label21.Text = "Net Total";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbSearchMethod);
            this.panel2.Controls.Add(this.lblPurchasTotalAmount);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.dgvGrid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(7, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 513);
            this.panel2.TabIndex = 365;
            // 
            // txtTotal
            // 
            this.txtTotal.Animated = true;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtTotal.BorderRadius = 5;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "0";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(635, 35);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "Total";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionStart = 1;
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(126, 45);
            this.txtTotal.TabIndex = 376;
            this.txtTotal.Tag = "Price is Required";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 377;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Animated = true;
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtDiscount.BorderRadius = 5;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(766, 35);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "Discount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 1;
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(126, 45);
            this.txtDiscount.TabIndex = 376;
            this.txtDiscount.Tag = "Price is Required";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 377;
            this.label4.Text = "Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbSearchMethod.ItemHeight = 39;
            this.cmbSearchMethod.Items.AddRange(new object[] {
            "Item Name",
            "Item Code"});
            this.cmbSearchMethod.ItemsAppearance.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.Location = new System.Drawing.Point(20, 37);
            this.cmbSearchMethod.Name = "cmbSearchMethod";
            this.cmbSearchMethod.ShadowDecoration.Parent = this.cmbSearchMethod;
            this.cmbSearchMethod.Size = new System.Drawing.Size(130, 45);
            this.cmbSearchMethod.StartIndex = 0;
            this.cmbSearchMethod.TabIndex = 375;
            // 
            // lblPurchasTotalAmount
            // 
            this.lblPurchasTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurchasTotalAmount.BorderRadius = 6;
            this.lblPurchasTotalAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.lblPurchasTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPurchasTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblPurchasTotalAmount.Location = new System.Drawing.Point(897, 37);
            this.lblPurchasTotalAmount.Name = "lblPurchasTotalAmount";
            this.lblPurchasTotalAmount.ShadowDecoration.Parent = this.lblPurchasTotalAmount;
            this.lblPurchasTotalAmount.Size = new System.Drawing.Size(200, 44);
            this.lblPurchasTotalAmount.TabIndex = 364;
            this.lblPurchasTotalAmount.TabStop = false;
            this.lblPurchasTotalAmount.Text = "0";
            this.lblPurchasTotalAmount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1138, 25);
            this.toolStrip1.TabIndex = 366;
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
            this.fileSaveToolStripMenuItem.Click += new System.EventHandler(this.fileSaveToolStripMenuItem_Click);
            // 
            // focusOnBarcodeToolStripMenuItem
            // 
            this.focusOnBarcodeToolStripMenuItem.Name = "focusOnBarcodeToolStripMenuItem";
            this.focusOnBarcodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.focusOnBarcodeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.focusOnBarcodeToolStripMenuItem.Text = "Focus On Barcode";
            this.focusOnBarcodeToolStripMenuItem.Click += new System.EventHandler(this.focusOnBarcodeToolStripMenuItem_Click);
            // 
            // gunaTooltip
            // 
            this.gunaTooltip.AllowLinksHandling = true;
            this.gunaTooltip.AutoPopDelay = 10000;
            this.gunaTooltip.InitialDelay = 500;
            this.gunaTooltip.MaximumSize = new System.Drawing.Size(0, 0);
            this.gunaTooltip.ReshowDelay = 20;
            this.gunaTooltip.ShowAlways = true;
            // 
            // linkSupplier
            // 
            this.linkSupplier.AutoSize = true;
            this.linkSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSupplier.Location = new System.Drawing.Point(24, 26);
            this.linkSupplier.Name = "linkSupplier";
            this.linkSupplier.Size = new System.Drawing.Size(61, 18);
            this.linkSupplier.TabIndex = 367;
            this.linkSupplier.TabStop = true;
            this.linkSupplier.Text = "Supplier";
            this.linkSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSupplier_LinkClicked);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPurchase.Animated = true;
            this.btnPurchase.BorderRadius = 10;
            this.btnPurchase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPurchase.CheckedState.Parent = this.btnPurchase;
            this.btnPurchase.CustomBorderColor = System.Drawing.Color.White;
            this.btnPurchase.CustomImages.Parent = this.btnPurchase;
            this.btnPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.HoverState.Parent = this.btnPurchase;
            this.btnPurchase.Location = new System.Drawing.Point(307, 622);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.ShadowDecoration.Parent = this.btnPurchase;
            this.btnPurchase.Size = new System.Drawing.Size(160, 46);
            this.btnPurchase.TabIndex = 368;
            this.btnPurchase.Text = "VIEW PURCHASE";
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnViewCheque
            // 
            this.btnViewCheque.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewCheque.Animated = true;
            this.btnViewCheque.BorderRadius = 10;
            this.btnViewCheque.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnViewCheque.CheckedState.Parent = this.btnViewCheque;
            this.btnViewCheque.CustomBorderColor = System.Drawing.Color.White;
            this.btnViewCheque.CustomImages.Parent = this.btnViewCheque;
            this.btnViewCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewCheque.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewCheque.ForeColor = System.Drawing.Color.White;
            this.btnViewCheque.HoverState.Parent = this.btnViewCheque;
            this.btnViewCheque.Location = new System.Drawing.Point(473, 622);
            this.btnViewCheque.Name = "btnViewCheque";
            this.btnViewCheque.ShadowDecoration.Parent = this.btnViewCheque;
            this.btnViewCheque.Size = new System.Drawing.Size(160, 46);
            this.btnViewCheque.TabIndex = 369;
            this.btnViewCheque.Text = "VIEW CHEQUE";
            this.btnViewCheque.Click += new System.EventHandler(this.btnViewCheque_Click);
            // 
            // btnPurchaseItems
            // 
            this.btnPurchaseItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPurchaseItems.Animated = true;
            this.btnPurchaseItems.BorderRadius = 10;
            this.btnPurchaseItems.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPurchaseItems.CheckedState.Parent = this.btnPurchaseItems;
            this.btnPurchaseItems.CustomBorderColor = System.Drawing.Color.White;
            this.btnPurchaseItems.CustomImages.Parent = this.btnPurchaseItems;
            this.btnPurchaseItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPurchaseItems.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPurchaseItems.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseItems.HoverState.Parent = this.btnPurchaseItems;
            this.btnPurchaseItems.Location = new System.Drawing.Point(639, 622);
            this.btnPurchaseItems.Name = "btnPurchaseItems";
            this.btnPurchaseItems.ShadowDecoration.Parent = this.btnPurchaseItems;
            this.btnPurchaseItems.Size = new System.Drawing.Size(160, 46);
            this.btnPurchaseItems.TabIndex = 370;
            this.btnPurchaseItems.Text = "PURCHASE ITEMS";
            this.btnPurchaseItems.Click += new System.EventHandler(this.btnPurchaseItems_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPaymentHistory.Animated = true;
            this.btnPaymentHistory.BorderRadius = 10;
            this.btnPaymentHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPaymentHistory.CheckedState.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.CustomBorderColor = System.Drawing.Color.White;
            this.btnPaymentHistory.CustomImages.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaymentHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.btnPaymentHistory.HoverState.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.Location = new System.Drawing.Point(805, 622);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.ShadowDecoration.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.Size = new System.Drawing.Size(160, 46);
            this.btnPaymentHistory.TabIndex = 371;
            this.btnPaymentHistory.Text = "PAYMENT HISTORY";
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMakePayment.Animated = true;
            this.btnMakePayment.BorderRadius = 10;
            this.btnMakePayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMakePayment.CheckedState.Parent = this.btnMakePayment;
            this.btnMakePayment.CustomBorderColor = System.Drawing.Color.White;
            this.btnMakePayment.CustomImages.Parent = this.btnMakePayment;
            this.btnMakePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMakePayment.ForeColor = System.Drawing.Color.White;
            this.btnMakePayment.HoverState.Parent = this.btnMakePayment;
            this.btnMakePayment.Location = new System.Drawing.Point(141, 622);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.ShadowDecoration.Parent = this.btnMakePayment;
            this.btnMakePayment.Size = new System.Drawing.Size(160, 46);
            this.btnMakePayment.TabIndex = 372;
            this.btnMakePayment.Text = "MAKE PAYMENT";
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // ucNewPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.linkSupplier);
            this.Controls.Add(this.btnViewCheque);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnPurchaseItems);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.dtpPurchseDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRefrenceNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.panel2);
            this.Name = "ucNewPurchaseForm";
            this.Size = new System.Drawing.Size(1138, 681);
            this.Load += new System.EventHandler(this.ucNewPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBarcode;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddSupplier;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtRefrenceNo;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPurchseDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.DataGridView dgvGrid;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlToolTip gunaTooltip;
        private System.Windows.Forms.ToolStripMenuItem focusOnBarcodeToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkSupplier;
        private Guna.UI2.WinForms.Guna2Button btnPurchase;
        private Guna.UI2.WinForms.Guna2Button btnViewCheque;
        private Guna.UI2.WinForms.Guna2Button btnPurchaseItems;
        private Guna.UI2.WinForms.Guna2Button btnPaymentHistory;
        private Guna.UI2.WinForms.Guna2Button btnMakePayment;
        private Guna.UI2.WinForms.Guna2Chip lblPurchasTotalAmount;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchMethod;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellCartID;
        private System.Windows.Forms.DataGridViewLinkColumn cellItem;
        private System.Windows.Forms.DataGridViewLinkColumn cellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellUnitTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewLinkColumn cellRemove;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}
