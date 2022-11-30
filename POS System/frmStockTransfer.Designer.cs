namespace POS_System
{
    partial class frmStockTransfer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockTransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.cellStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStorageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvTransferHistory = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.chipQtyOnHand = new Guna.UI2.WinForms.Guna2Chip();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageTransfer = new System.Windows.Forms.TabPage();
            this.pageTransferHistory = new System.Windows.Forms.TabPage();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferHistory)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pageTransfer.SuspendLayout();
            this.pageTransferHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Chip1;
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
            this.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.FocusedState.Parent = this.txtBarcode;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.HoverState.Parent = this.txtBarcode;
            this.txtBarcode.Location = new System.Drawing.Point(373, 77);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.PlaceholderText = "Your Item Barcode";
            this.txtBarcode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.ShadowDecoration.Parent = this.txtBarcode;
            this.txtBarcode.Size = new System.Drawing.Size(268, 35);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.Tag = "Barcode Number Required";
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Barcode";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 0);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(1200, 54);
            this.guna2Chip1.TabIndex = 10;
            this.guna2Chip1.Text = "STOCK TRANSFER";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(1151, 6);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.TabIndex = 11;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(1018, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(131, 35);
            this.btnSave.TabIndex = 346;
            this.btnSave.Text = "transfer";
            this.btnSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 347;
            this.label5.Text = "From";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellStockID,
            this.cellItemID,
            this.cellStorageID,
            this.Column1,
            this.cellBatch,
            this.cellQuantity,
            this.cellLocation,
            this.Column3,
            this.costprice,
            this.Column6,
            this.Column7});
            this.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.White;
            this.dgvStock.Location = new System.Drawing.Point(6, 6);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvStock.RowHeadersVisible = false;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvStock.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowTemplate.DividerHeight = 1;
            this.dgvStock.RowTemplate.Height = 35;
            this.dgvStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.ShowCellToolTips = false;
            this.dgvStock.Size = new System.Drawing.Size(1143, 329);
            this.dgvStock.TabIndex = 353;
            this.dgvStock.TabStop = false;
            this.dgvStock.DataSourceChanged += new System.EventHandler(this.dgvStock_DataSourceChanged);
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
            // 
            // cellStockID
            // 
            this.cellStockID.DataPropertyName = "stockid";
            this.cellStockID.HeaderText = "stockID";
            this.cellStockID.Name = "cellStockID";
            this.cellStockID.ReadOnly = true;
            this.cellStockID.Visible = false;
            // 
            // cellItemID
            // 
            this.cellItemID.DataPropertyName = "item_id";
            this.cellItemID.HeaderText = "item_id";
            this.cellItemID.Name = "cellItemID";
            this.cellItemID.ReadOnly = true;
            this.cellItemID.Visible = false;
            // 
            // cellStorageID
            // 
            this.cellStorageID.DataPropertyName = "storage_id";
            this.cellStorageID.HeaderText = "storage_id";
            this.cellStorageID.Name = "cellStorageID";
            this.cellStorageID.ReadOnly = true;
            this.cellStorageID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itm_name";
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cellBatch
            // 
            this.cellBatch.DataPropertyName = "batch_no";
            this.cellBatch.FillWeight = 80F;
            this.cellBatch.HeaderText = "Batch";
            this.cellBatch.Name = "cellBatch";
            this.cellBatch.ReadOnly = true;
            // 
            // cellQuantity
            // 
            this.cellQuantity.DataPropertyName = "available";
            this.cellQuantity.FillWeight = 60F;
            this.cellQuantity.HeaderText = "Qty";
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ReadOnly = true;
            // 
            // cellLocation
            // 
            this.cellLocation.DataPropertyName = "name";
            this.cellLocation.HeaderText = "Location";
            this.cellLocation.Name = "cellLocation";
            this.cellLocation.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sale_price";
            this.Column3.FillWeight = 60F;
            this.Column3.HeaderText = "Sale Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // costprice
            // 
            this.costprice.DataPropertyName = "cost";
            this.costprice.FillWeight = 80F;
            this.costprice.HeaderText = "Cost Price";
            this.costprice.Name = "costprice";
            this.costprice.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mf_date";
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "MFG";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "exp_date";
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "EXP";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 347;
            this.label1.Text = "To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTo
            // 
            this.cmbTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTo.Animated = true;
            this.cmbTo.BackColor = System.Drawing.Color.Transparent;
            this.cmbTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbTo.BorderRadius = 5;
            this.cmbTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTo.FocusedState.Parent = this.cmbTo;
            this.cmbTo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.HoverState.Parent = this.cmbTo;
            this.cmbTo.ItemHeight = 30;
            this.cmbTo.ItemsAppearance.Parent = this.cmbTo;
            this.cmbTo.Location = new System.Drawing.Point(305, 411);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.ShadowDecoration.Parent = this.cmbTo;
            this.cmbTo.Size = new System.Drawing.Size(185, 36);
            this.cmbTo.TabIndex = 348;
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFrom.Animated = true;
            this.txtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtFrom.BorderRadius = 5;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultText = "";
            this.txtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.DisabledState.Parent = this.txtFrom;
            this.txtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.FocusedState.Parent = this.txtFrom;
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFrom.HoverState.Parent = this.txtFrom;
            this.txtFrom.Location = new System.Drawing.Point(110, 412);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderText = "Stock From";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrom.SelectedText = "";
            this.txtFrom.ShadowDecoration.Parent = this.txtFrom;
            this.txtFrom.Size = new System.Drawing.Size(174, 35);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Tag = "Barcode Number Required";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qty.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderRadius = 5;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "0";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(12, 412);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 1;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(72, 35);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Tag = "";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpExpiry.BorderRadius = 8;
            this.dtpExpiry.CheckedState.Parent = this.dtpExpiry;
            this.dtpExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpExpiry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpExpiry.ForeColor = System.Drawing.Color.White;
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.HoverState.Parent = this.dtpExpiry;
            this.dtpExpiry.Location = new System.Drawing.Point(509, 411);
            this.dtpExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.ShadowDecoration.Parent = this.dtpExpiry;
            this.dtpExpiry.Size = new System.Drawing.Size(150, 35);
            this.dtpExpiry.TabIndex = 354;
            this.dtpExpiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpExpiry.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // dgvTransferHistory
            // 
            this.dgvTransferHistory.AllowUserToAddRows = false;
            this.dgvTransferHistory.AllowUserToDeleteRows = false;
            this.dgvTransferHistory.AllowUserToResizeColumns = false;
            this.dgvTransferHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransferHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvTransferHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransferHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransferHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransferHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvTransferHistory.ColumnHeadersHeight = 40;
            this.dgvTransferHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransferHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvTransferHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferHistory.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvTransferHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferHistory.EnableHeadersVisualStyles = false;
            this.dgvTransferHistory.GridColor = System.Drawing.Color.White;
            this.dgvTransferHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvTransferHistory.MultiSelect = false;
            this.dgvTransferHistory.Name = "dgvTransferHistory";
            this.dgvTransferHistory.ReadOnly = true;
            this.dgvTransferHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvTransferHistory.RowHeadersVisible = false;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferHistory.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransferHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferHistory.RowTemplate.DividerHeight = 1;
            this.dgvTransferHistory.RowTemplate.Height = 35;
            this.dgvTransferHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferHistory.ShowCellToolTips = false;
            this.dgvTransferHistory.Size = new System.Drawing.Size(1149, 446);
            this.dgvTransferHistory.TabIndex = 353;
            this.dgvTransferHistory.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 347;
            this.label4.Text = "Note";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.Animated = true;
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtNote.BorderRadius = 5;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(675, 410);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "Note";
            this.txtNote.ReadOnly = true;
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(335, 35);
            this.txtNote.TabIndex = 4;
            this.txtNote.Tag = "";
            // 
            // chipQtyOnHand
            // 
            this.chipQtyOnHand.BorderRadius = 6;
            this.chipQtyOnHand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.chipQtyOnHand.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.chipQtyOnHand.ForeColor = System.Drawing.Color.White;
            this.chipQtyOnHand.Location = new System.Drawing.Point(1047, 63);
            this.chipQtyOnHand.Name = "chipQtyOnHand";
            this.chipQtyOnHand.ShadowDecoration.Parent = this.chipQtyOnHand;
            this.chipQtyOnHand.Size = new System.Drawing.Size(141, 55);
            this.chipQtyOnHand.TabIndex = 355;
            this.chipQtyOnHand.Text = "0";
            this.chipQtyOnHand.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(905, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Quantity";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMode
            // 
            this.cmbMode.Animated = true;
            this.cmbMode.AutoRoundedCorners = true;
            this.cmbMode.BackColor = System.Drawing.Color.White;
            this.cmbMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbMode.BorderRadius = 17;
            this.cmbMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMode.FocusedState.Parent = this.cmbMode;
            this.cmbMode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.HoverState.Parent = this.cmbMode;
            this.cmbMode.ItemHeight = 30;
            this.cmbMode.Items.AddRange(new object[] {
            "Transfer",
            "Transfer History"});
            this.cmbMode.ItemsAppearance.Parent = this.cmbMode;
            this.cmbMode.Location = new System.Drawing.Point(119, 76);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.ShadowDecoration.Parent = this.cmbMode;
            this.cmbMode.Size = new System.Drawing.Size(180, 36);
            this.cmbMode.StartIndex = 0;
            this.cmbMode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbMode.TabIndex = 356;
            this.cmbMode.SelectionChangeCommitted += new System.EventHandler(this.cmbMode_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageTransfer);
            this.tabControl1.Controls.Add(this.pageTransferHistory);
            this.tabControl1.Location = new System.Drawing.Point(25, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 478);
            this.tabControl1.TabIndex = 357;
            // 
            // pageTransfer
            // 
            this.pageTransfer.Controls.Add(this.dgvStock);
            this.pageTransfer.Controls.Add(this.txtQuantity);
            this.pageTransfer.Controls.Add(this.btnSave);
            this.pageTransfer.Controls.Add(this.label4);
            this.pageTransfer.Controls.Add(this.dtpExpiry);
            this.pageTransfer.Controls.Add(this.label2);
            this.pageTransfer.Controls.Add(this.txtNote);
            this.pageTransfer.Controls.Add(this.cmbTo);
            this.pageTransfer.Controls.Add(this.label1);
            this.pageTransfer.Controls.Add(this.txtFrom);
            this.pageTransfer.Controls.Add(this.label5);
            this.pageTransfer.Controls.Add(this.label3);
            this.pageTransfer.Location = new System.Drawing.Point(4, 22);
            this.pageTransfer.Name = "pageTransfer";
            this.pageTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.pageTransfer.Size = new System.Drawing.Size(1155, 452);
            this.pageTransfer.TabIndex = 0;
            this.pageTransfer.Text = "Transfer";
            this.pageTransfer.UseVisualStyleBackColor = true;
            // 
            // pageTransferHistory
            // 
            this.pageTransferHistory.Controls.Add(this.dgvTransferHistory);
            this.pageTransferHistory.Location = new System.Drawing.Point(4, 22);
            this.pageTransferHistory.Name = "pageTransferHistory";
            this.pageTransferHistory.Padding = new System.Windows.Forms.Padding(3);
            this.pageTransferHistory.Size = new System.Drawing.Size(1155, 452);
            this.pageTransferHistory.TabIndex = 1;
            this.pageTransferHistory.Text = "Transfer History";
            this.pageTransferHistory.UseVisualStyleBackColor = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "itm_name";
            this.Column5.HeaderText = "Item";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "batch_no";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.FillWeight = 60F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "transfered_from";
            this.dataGridViewTextBoxColumn4.FillWeight = 130F;
            this.dataGridViewTextBoxColumn4.HeaderText = "From";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "transfered_to";
            this.Column8.FillWeight = 130F;
            this.Column8.HeaderText = "To";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "transfer_at";
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "remark";
            this.Column10.HeaderText = "Note";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "View Mode";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmStockTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 608);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.chipQtyOnHand);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStockTransfer";
            this.Shown += new System.EventHandler(this.frmStockTransfer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferHistory)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pageTransfer.ResumeLayout(false);
            this.pageTransfer.PerformLayout();
            this.pageTransferHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtBarcode;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStock;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFrom;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiry;
        private System.Windows.Forms.DataGridView dgvTransferHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2Chip chipQtyOnHand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStorageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn costprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageTransfer;
        private System.Windows.Forms.TabPage pageTransferHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label7;
    }
}