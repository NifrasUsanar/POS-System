namespace POS_System
{
    partial class ucCheque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCheque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlView = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.chipTotal = new Guna.UI2.WinForms.Guna2Chip();
            this.dgvCheque = new System.Windows.Forms.DataGridView();
            this.btnReportPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cmbChequeMode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPeopleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellIsParty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPeople = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cellRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.label7);
            this.pnlView.Controls.Add(this.chipTotal);
            this.pnlView.Controls.Add(this.dgvCheque);
            this.pnlView.Controls.Add(this.btnReportPrint);
            this.pnlView.Controls.Add(this.btnRefresh);
            this.pnlView.Controls.Add(this.btnSearch);
            this.pnlView.Controls.Add(this.cmbChequeMode);
            this.pnlView.Controls.Add(this.txtSearch);
            this.pnlView.Controls.Add(this.dtpEnd);
            this.pnlView.Controls.Add(this.dtpStart);
            this.pnlView.Controls.Add(this.cmbStatus);
            this.pnlView.Controls.Add(this.label1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1028, 402);
            this.pnlView.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 25);
            this.label7.TabIndex = 380;
            this.label7.Text = "Total Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chipTotal
            // 
            this.chipTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chipTotal.BorderRadius = 6;
            this.chipTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chipTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.chipTotal.ForeColor = System.Drawing.Color.White;
            this.chipTotal.Location = new System.Drawing.Point(802, 361);
            this.chipTotal.Name = "chipTotal";
            this.chipTotal.ShadowDecoration.Parent = this.chipTotal;
            this.chipTotal.Size = new System.Drawing.Size(219, 34);
            this.chipTotal.TabIndex = 381;
            this.chipTotal.TabStop = false;
            this.chipTotal.Text = "Rs. 0";
            this.chipTotal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dgvCheque
            // 
            this.dgvCheque.AllowUserToAddRows = false;
            this.dgvCheque.AllowUserToDeleteRows = false;
            this.dgvCheque.AllowUserToResizeColumns = false;
            this.dgvCheque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCheque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheque.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCheque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheque.ColumnHeadersHeight = 35;
            this.dgvCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cellPeopleID,
            this.cellIsParty,
            this.cellPeople,
            this.Column5,
            this.Column4,
            this.cellAmount,
            this.Column8,
            this.Column7,
            this.cellStatus,
            this.btnEdit,
            this.cellRemove});
            this.dgvCheque.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheque.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCheque.EnableHeadersVisualStyles = false;
            this.dgvCheque.GridColor = System.Drawing.Color.White;
            this.dgvCheque.Location = new System.Drawing.Point(3, 68);
            this.dgvCheque.MultiSelect = false;
            this.dgvCheque.Name = "dgvCheque";
            this.dgvCheque.ReadOnly = true;
            this.dgvCheque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheque.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCheque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCheque.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheque.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCheque.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCheque.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCheque.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCheque.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheque.RowTemplate.DividerHeight = 1;
            this.dgvCheque.RowTemplate.Height = 35;
            this.dgvCheque.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheque.ShowCellToolTips = false;
            this.dgvCheque.Size = new System.Drawing.Size(1018, 282);
            this.dgvCheque.TabIndex = 310;
            this.dgvCheque.TabStop = false;
            this.dgvCheque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheque_CellContentClick);
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportPrint.Animated = true;
            this.btnReportPrint.CheckedState.Parent = this.btnReportPrint;
            this.btnReportPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportPrint.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReportPrint.CustomImages.Parent = this.btnReportPrint;
            this.btnReportPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnReportPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportPrint.ForeColor = System.Drawing.Color.White;
            this.btnReportPrint.HoverState.Parent = this.btnReportPrint;
            this.btnReportPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPrint.Image")));
            this.btnReportPrint.Location = new System.Drawing.Point(981, 13);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReportPrint.ShadowDecoration.Parent = this.btnReportPrint;
            this.btnReportPrint.Size = new System.Drawing.Size(40, 40);
            this.btnReportPrint.TabIndex = 325;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(938, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 324;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(894, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 323;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbChequeMode
            // 
            this.cmbChequeMode.Animated = true;
            this.cmbChequeMode.AutoRoundedCorners = true;
            this.cmbChequeMode.BackColor = System.Drawing.Color.White;
            this.cmbChequeMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbChequeMode.BorderRadius = 17;
            this.cmbChequeMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChequeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChequeMode.FocusedColor = System.Drawing.Color.Empty;
            this.cmbChequeMode.FocusedState.Parent = this.cmbChequeMode;
            this.cmbChequeMode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbChequeMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChequeMode.FormattingEnabled = true;
            this.cmbChequeMode.HoverState.Parent = this.cmbChequeMode;
            this.cmbChequeMode.ItemHeight = 30;
            this.cmbChequeMode.Items.AddRange(new object[] {
            "Customer Cheque",
            "My Cheque"});
            this.cmbChequeMode.ItemsAppearance.Parent = this.cmbChequeMode;
            this.cmbChequeMode.Location = new System.Drawing.Point(16, 15);
            this.cmbChequeMode.Name = "cmbChequeMode";
            this.cmbChequeMode.ShadowDecoration.Parent = this.cmbChequeMode;
            this.cmbChequeMode.Size = new System.Drawing.Size(167, 36);
            this.cmbChequeMode.StartIndex = 0;
            this.cmbChequeMode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbChequeMode.TabIndex = 321;
            this.cmbChequeMode.SelectionChangeCommitted += new System.EventHandler(this.cmbChequeMode_SelectionChangeCommitted);
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
            this.txtSearch.Location = new System.Drawing.Point(200, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Cheque No or Owner name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(220, 36);
            this.txtSearch.TabIndex = 317;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dtpEnd.Location = new System.Drawing.Point(759, 15);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(133, 36);
            this.dtpEnd.TabIndex = 318;
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
            this.dtpStart.Location = new System.Drawing.Point(601, 15);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(129, 36);
            this.dtpStart.TabIndex = 319;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Animated = true;
            this.cmbStatus.AutoRoundedCorners = true;
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbStatus.BorderRadius = 17;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.FocusedState.Parent = this.cmbStatus;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.HoverState.Parent = this.cmbStatus;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Pending",
            "Return",
            "Cancelled",
            "Deposited"});
            this.cmbStatus.ItemsAppearance.Parent = this.cmbStatus;
            this.cmbStatus.Location = new System.Drawing.Point(427, 15);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.ShadowDecoration.Parent = this.cmbStatus;
            this.cmbStatus.Size = new System.Drawing.Size(152, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 320;
            this.cmbStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbStatus_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(732, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 322;
            this.label1.Text = "TO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlView);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1028, 402);
            this.pnlContainer.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "payment_id";
            this.id.FillWeight = 20F;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cellPeopleID
            // 
            this.cellPeopleID.DataPropertyName = "people_id";
            this.cellPeopleID.HeaderText = "peopleID";
            this.cellPeopleID.Name = "cellPeopleID";
            this.cellPeopleID.ReadOnly = true;
            this.cellPeopleID.Visible = false;
            // 
            // cellIsParty
            // 
            this.cellIsParty.DataPropertyName = "is_party";
            this.cellIsParty.HeaderText = "Is Party";
            this.cellIsParty.Name = "cellIsParty";
            this.cellIsParty.ReadOnly = true;
            this.cellIsParty.Visible = false;
            // 
            // cellPeople
            // 
            this.cellPeople.DataPropertyName = "name";
            this.cellPeople.FillWeight = 130F;
            this.cellPeople.HeaderText = "Customer";
            this.cellPeople.Name = "cellPeople";
            this.cellPeople.ReadOnly = true;
            this.cellPeople.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellPeople.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cheque_no";
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Cheque No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "bankname";
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Bank Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cellAmount
            // 
            this.cellAmount.DataPropertyName = "amount";
            dataGridViewCellStyle3.Format = "N2";
            this.cellAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.cellAmount.FillWeight = 70F;
            this.cellAmount.HeaderText = "Amount";
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cheque_type";
            this.Column8.FillWeight = 60F;
            this.Column8.HeaderText = "Cheque Type";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cheque_date";
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // cellStatus
            // 
            this.cellStatus.DataPropertyName = "cheque_status";
            this.cellStatus.FillWeight = 50F;
            this.cellStatus.HeaderText = "Status";
            this.cellStatus.Name = "cellStatus";
            this.cellStatus.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FillWeight = 40F;
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // cellRemove
            // 
            this.cellRemove.FillWeight = 30F;
            this.cellRemove.HeaderText = "Remove";
            this.cellRemove.Name = "cellRemove";
            this.cellRemove.ReadOnly = true;
            this.cellRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellRemove.Text = "Remove";
            this.cellRemove.UseColumnTextForLinkValue = true;
            // 
            // ucCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "ucCheque";
            this.Size = new System.Drawing.Size(1028, 402);
            this.Load += new System.EventHandler(this.ucCheque_Load);
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheque)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvCheque;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefresh;
        private Guna.UI2.WinForms.Guna2CircleButton btnReportPrint;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChequeMode;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Chip chipTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPeopleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellIsParty;
        private System.Windows.Forms.DataGridViewLinkColumn cellPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellStatus;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn cellRemove;
    }
}
