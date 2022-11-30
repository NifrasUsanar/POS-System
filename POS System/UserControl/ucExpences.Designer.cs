namespace POS_System
{
    partial class ucExpences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucExpences));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPayment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.dgvExpences = new System.Windows.Forms.DataGridView();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDesc = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chipTotal = new Guna.UI2.WinForms.Guna2Chip();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnReportPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpences)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.FillWeight = 30F;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnView.HeaderText = "";
            this.btnView.Name = "btnView";
            this.btnView.ReadOnly = true;
            this.btnView.Text = "View";
            this.btnView.UseColumnTextForButtonValue = true;
            // 
            // saleid
            // 
            this.saleid.DataPropertyName = "id";
            this.saleid.FillWeight = 20F;
            this.saleid.HeaderText = "#";
            this.saleid.Name = "saleid";
            this.saleid.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.FillWeight = 40F;
            this.btnPrint.HeaderText = "";
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ReadOnly = true;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseColumnTextForButtonValue = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.FillWeight = 80F;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // paidamount
            // 
            this.paidamount.DataPropertyName = "paid_amount";
            this.paidamount.FillWeight = 80F;
            this.paidamount.HeaderText = "Paid Amount";
            this.paidamount.Name = "paidamount";
            this.paidamount.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.FillWeight = 80F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.FillWeight = 60F;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPayment.HeaderText = "";
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.ReadOnly = true;
            this.btnAddPayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAddPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseColumnTextForButtonValue = true;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "created_at";
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Customer";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "people_id";
            this.customerID.HeaderText = "customerID";
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "status";
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.Animated = true;
            this.btnNew.AutoRoundedCorners = true;
            this.btnNew.BorderRadius = 17;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.FillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNew.ImageSize = new System.Drawing.Size(18, 18);
            this.btnNew.Location = new System.Drawing.Point(6, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(156, 36);
            this.btnNew.TabIndex = 327;
            this.btnNew.Text = "ADD EXPENSES";
            this.btnNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvExpences
            // 
            this.dgvExpences.AllowUserToAddRows = false;
            this.dgvExpences.AllowUserToDeleteRows = false;
            this.dgvExpences.AllowUserToResizeColumns = false;
            this.dgvExpences.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpences.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvExpences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpences.ColumnHeadersHeight = 40;
            this.dgvExpences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellDesc,
            this.Column3,
            this.Column5,
            this.cellRemove});
            this.dgvExpences.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpences.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpences.EnableHeadersVisualStyles = false;
            this.dgvExpences.GridColor = System.Drawing.Color.White;
            this.dgvExpences.Location = new System.Drawing.Point(11, 73);
            this.dgvExpences.MultiSelect = false;
            this.dgvExpences.Name = "dgvExpences";
            this.dgvExpences.ReadOnly = true;
            this.dgvExpences.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpences.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpences.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpences.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExpences.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvExpences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpences.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvExpences.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvExpences.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpences.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpences.RowTemplate.DividerHeight = 1;
            this.dgvExpences.RowTemplate.Height = 35;
            this.dgvExpences.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpences.ShowCellToolTips = false;
            this.dgvExpences.Size = new System.Drawing.Size(1046, 435);
            this.dgvExpences.TabIndex = 328;
            this.dgvExpences.TabStop = false;
            this.dgvExpences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpences_CellContentClick);
            // 
            // cellID
            // 
            this.cellID.DataPropertyName = "expences_id";
            this.cellID.FillWeight = 10F;
            this.cellID.HeaderText = "#";
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            this.cellID.Visible = false;
            // 
            // cellDesc
            // 
            this.cellDesc.DataPropertyName = "discription";
            this.cellDesc.HeaderText = "Description";
            this.cellDesc.Name = "cellDesc";
            this.cellDesc.ReadOnly = true;
            this.cellDesc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "amount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Date";
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cellRemove
            // 
            this.cellRemove.FillWeight = 30F;
            this.cellRemove.HeaderText = "Remove";
            this.cellRemove.Name = "cellRemove";
            this.cellRemove.ReadOnly = true;
            this.cellRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellRemove.Text = "Delete";
            this.cellRemove.UseColumnTextForLinkValue = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chipTotal);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnReportPrint);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 49);
            this.panel1.TabIndex = 329;
            // 
            // chipTotal
            // 
            this.chipTotal.BackColor = System.Drawing.Color.White;
            this.chipTotal.BorderRadius = 10;
            this.chipTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chipTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.chipTotal.ForeColor = System.Drawing.Color.White;
            this.chipTotal.Location = new System.Drawing.Point(437, 6);
            this.chipTotal.Name = "chipTotal";
            this.chipTotal.ShadowDecoration.Parent = this.chipTotal;
            this.chipTotal.Size = new System.Drawing.Size(182, 38);
            this.chipTotal.TabIndex = 372;
            this.chipTotal.TabStop = false;
            this.chipTotal.Text = "0";
            this.chipTotal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.btnSearch.Location = new System.Drawing.Point(906, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 336;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.dtpStart.Location = new System.Drawing.Point(627, 7);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(124, 36);
            this.dtpStart.TabIndex = 331;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(948, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 334;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportPrint.Animated = true;
            this.btnReportPrint.BackColor = System.Drawing.Color.White;
            this.btnReportPrint.CheckedState.Parent = this.btnReportPrint;
            this.btnReportPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportPrint.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReportPrint.CustomImages.Parent = this.btnReportPrint;
            this.btnReportPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnReportPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportPrint.ForeColor = System.Drawing.Color.White;
            this.btnReportPrint.HoverState.Parent = this.btnReportPrint;
            this.btnReportPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPrint.Image")));
            this.btnReportPrint.Location = new System.Drawing.Point(992, 5);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReportPrint.ShadowDecoration.Parent = this.btnReportPrint;
            this.btnReportPrint.Size = new System.Drawing.Size(40, 40);
            this.btnReportPrint.TabIndex = 335;
            this.btnReportPrint.Visible = false;
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
            this.dtpEnd.Location = new System.Drawing.Point(775, 7);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(125, 36);
            this.dtpEnd.TabIndex = 332;
            this.dtpEnd.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
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
            this.txtSearch.Location = new System.Drawing.Point(166, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(261, 36);
            this.txtSearch.TabIndex = 330;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(747, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 40);
            this.label1.TabIndex = 333;
            this.label1.Text = "TO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucExpences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvExpences);
            this.Name = "ucExpences";
            this.Size = new System.Drawing.Size(1064, 520);
            this.Load += new System.EventHandler(this.usExpences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpences)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleid;
        private System.Windows.Forms.DataGridViewButtonColumn btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn btnAddPayment;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.DataGridView dgvExpences;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefresh;
        private Guna.UI2.WinForms.Guna2CircleButton btnReportPrint;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Chip chipTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewLinkColumn cellDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn cellRemove;
    }
}
