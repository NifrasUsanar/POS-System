namespace POS_System
{
    partial class ucPaymentLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPaymentLog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeople = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chipTotal = new Guna.UI2.WinForms.Guna2Chip();
            this.cellPaymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPeopleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellRefrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToAddRows = false;
            this.dgvPayment.AllowUserToDeleteRows = false;
            this.dgvPayment.AllowUserToResizeColumns = false;
            this.dgvPayment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.ColumnHeadersHeight = 40;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellPaymentID,
            this.cellPeopleID,
            this.cellRefrence,
            this.Column6,
            this.cellPeople,
            this.cellPaymentType,
            this.cellAmount,
            this.Column5,
            this.cellDelete});
            this.dgvPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayment.EnableHeadersVisualStyles = false;
            this.dgvPayment.GridColor = System.Drawing.Color.White;
            this.dgvPayment.Location = new System.Drawing.Point(13, 78);
            this.dgvPayment.MultiSelect = false;
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayment.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvPayment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPayment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPayment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowTemplate.DividerHeight = 1;
            this.dgvPayment.RowTemplate.Height = 35;
            this.dgvPayment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayment.ShowCellToolTips = false;
            this.dgvPayment.Size = new System.Drawing.Size(1008, 419);
            this.dgvPayment.TabIndex = 326;
            this.dgvPayment.TabStop = false;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(131, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "People Name / ID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(258, 36);
            this.txtSearch.TabIndex = 339;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.Animated = true;
            this.cmbPaymentType.AutoRoundedCorners = true;
            this.cmbPaymentType.BackColor = System.Drawing.Color.White;
            this.cmbPaymentType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbPaymentType.BorderRadius = 17;
            this.cmbPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPaymentType.FocusedState.Parent = this.cmbPaymentType;
            this.cmbPaymentType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPaymentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.HoverState.Parent = this.cmbPaymentType;
            this.cmbPaymentType.ItemHeight = 30;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Cheque",
            "Account"});
            this.cmbPaymentType.ItemsAppearance.Parent = this.cmbPaymentType;
            this.cmbPaymentType.Location = new System.Drawing.Point(396, 22);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.ShadowDecoration.Parent = this.cmbPaymentType;
            this.cmbPaymentType.Size = new System.Drawing.Size(168, 36);
            this.cmbPaymentType.StartIndex = 0;
            this.cmbPaymentType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbPaymentType.TabIndex = 338;
            this.cmbPaymentType.SelectionChangeCommitted += new System.EventHandler(this.cmbPaymentType_SelectionChangeCommitted);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(981, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 337;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Animated = true;
            this.dtpEnd.AutoRoundedCorners = true;
            this.dtpEnd.BackColor = System.Drawing.Color.White;
            this.dtpEnd.BorderRadius = 17;
            this.dtpEnd.CheckedState.Parent = this.dtpEnd;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.White;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.HoverState.Parent = this.dtpEnd;
            this.dtpEnd.Location = new System.Drawing.Point(845, 19);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(134, 36);
            this.dtpEnd.TabIndex = 333;
            this.dtpEnd.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Animated = true;
            this.dtpStart.AutoRoundedCorners = true;
            this.dtpStart.BackColor = System.Drawing.Color.White;
            this.dtpStart.BorderRadius = 17;
            this.dtpStart.CheckedState.Parent = this.dtpStart;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.HoverState.Parent = this.dtpStart;
            this.dtpStart.Location = new System.Drawing.Point(687, 19);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(133, 36);
            this.dtpStart.TabIndex = 334;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(589, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 335;
            this.label2.Text = "Filter by Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(819, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 336;
            this.label1.Text = "TO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPeople
            // 
            this.cmbPeople.Animated = true;
            this.cmbPeople.AutoRoundedCorners = true;
            this.cmbPeople.BackColor = System.Drawing.Color.White;
            this.cmbPeople.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbPeople.BorderRadius = 17;
            this.cmbPeople.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeople.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPeople.FocusedState.Parent = this.cmbPeople;
            this.cmbPeople.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeople.FormattingEnabled = true;
            this.cmbPeople.HoverState.Parent = this.cmbPeople;
            this.cmbPeople.ItemHeight = 30;
            this.cmbPeople.Items.AddRange(new object[] {
            "Customer",
            "Vendor"});
            this.cmbPeople.ItemsAppearance.Parent = this.cmbPeople;
            this.cmbPeople.Location = new System.Drawing.Point(13, 21);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.ShadowDecoration.Parent = this.cmbPeople;
            this.cmbPeople.Size = new System.Drawing.Size(113, 36);
            this.cmbPeople.StartIndex = 0;
            this.cmbPeople.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbPeople.TabIndex = 338;
            this.cmbPeople.SelectionChangeCommitted += new System.EventHandler(this.cmbPeople_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(744, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 376;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chipTotal
            // 
            this.chipTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chipTotal.BorderRadius = 6;
            this.chipTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chipTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chipTotal.ForeColor = System.Drawing.Color.White;
            this.chipTotal.Location = new System.Drawing.Point(807, 503);
            this.chipTotal.Name = "chipTotal";
            this.chipTotal.ShadowDecoration.Parent = this.chipTotal;
            this.chipTotal.Size = new System.Drawing.Size(219, 34);
            this.chipTotal.TabIndex = 377;
            this.chipTotal.TabStop = false;
            this.chipTotal.Text = "Rs. 0";
            this.chipTotal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cellPaymentID
            // 
            this.cellPaymentID.DataPropertyName = "payment_id";
            this.cellPaymentID.FillWeight = 20F;
            this.cellPaymentID.HeaderText = "#";
            this.cellPaymentID.Name = "cellPaymentID";
            this.cellPaymentID.ReadOnly = true;
            this.cellPaymentID.Visible = false;
            // 
            // cellPeopleID
            // 
            this.cellPeopleID.DataPropertyName = "people_id";
            this.cellPeopleID.HeaderText = "peopleid";
            this.cellPeopleID.Name = "cellPeopleID";
            this.cellPeopleID.ReadOnly = true;
            this.cellPeopleID.Visible = false;
            // 
            // cellRefrence
            // 
            this.cellRefrence.DataPropertyName = "refrence_id";
            this.cellRefrence.FillWeight = 50F;
            this.cellRefrence.HeaderText = "Invoice";
            this.cellRefrence.Name = "cellRefrence";
            this.cellRefrence.ReadOnly = true;
            this.cellRefrence.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "created_at";
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cellPeople
            // 
            this.cellPeople.DataPropertyName = "name";
            this.cellPeople.HeaderText = "Customer";
            this.cellPeople.Name = "cellPeople";
            this.cellPeople.ReadOnly = true;
            // 
            // cellPaymentType
            // 
            this.cellPaymentType.DataPropertyName = "payment_type";
            this.cellPaymentType.FillWeight = 60F;
            this.cellPaymentType.HeaderText = "Description";
            this.cellPaymentType.Name = "cellPaymentType";
            this.cellPaymentType.ReadOnly = true;
            // 
            // cellAmount
            // 
            this.cellAmount.DataPropertyName = "amount";
            dataGridViewCellStyle3.Format = "N2";
            this.cellAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.cellAmount.FillWeight = 60F;
            this.cellAmount.HeaderText = "Amount";
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "note";
            dataGridViewCellStyle4.NullValue = "...";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Note";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cellDelete
            // 
            this.cellDelete.FillWeight = 30F;
            this.cellDelete.HeaderText = "Remove";
            this.cellDelete.Name = "cellDelete";
            this.cellDelete.ReadOnly = true;
            this.cellDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellDelete.Text = "Remove";
            this.cellDelete.UseColumnTextForLinkValue = true;
            // 
            // ucPaymentLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chipTotal);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbPeople);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayment);
            this.Name = "ucPaymentLog";
            this.Size = new System.Drawing.Size(1035, 544);
            this.Load += new System.EventHandler(this.ucPaymentLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPayment;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPaymentType;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeople;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Chip chipTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPeopleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellRefrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn cellDelete;
    }
}
