namespace POS_System
{
    partial class ucPeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPeople = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.people_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellBalance = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellAccount = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellPayment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.chipOutstanding = new Guna.UI2.WinForms.Guna2Chip();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chipCount = new Guna.UI2.WinForms.Guna2Chip();
            this.pnlContainer.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlView);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1021, 477);
            this.pnlContainer.TabIndex = 7;
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.dgvPeople);
            this.pnlView.Controls.Add(this.panel2);
            this.pnlView.Controls.Add(this.panel1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1021, 477);
            this.pnlView.TabIndex = 3;
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToResizeColumns = false;
            this.dgvPeople.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPeople.ColumnHeadersHeight = 35;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.people_id,
            this.Column1,
            this.cellName,
            this.Column5,
            this.Column3,
            this.Column7,
            this.cellBalance,
            this.cellAccount,
            this.cellPayment});
            this.dgvPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.NullValue = "...";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.Color.White;
            this.dgvPeople.Location = new System.Drawing.Point(0, 56);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeople.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPeople.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeople.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPeople.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvPeople.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPeople.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPeople.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowTemplate.DividerHeight = 1;
            this.dgvPeople.RowTemplate.Height = 30;
            this.dgvPeople.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.ShowCellToolTips = false;
            this.dgvPeople.Size = new System.Drawing.Size(1021, 374);
            this.dgvPeople.TabIndex = 309;
            this.dgvPeople.TabStop = false;
            this.dgvPeople.DataSourceChanged += new System.EventHandler(this.dgvPeople_DataSourceChanged);
            this.dgvPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            this.dgvPeople.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPeople_RowPrePaint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chipCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chipOutstanding);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 47);
            this.panel2.TabIndex = 311;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbPeople);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 56);
            this.panel1.TabIndex = 310;
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
            this.cmbPeople.Location = new System.Drawing.Point(6, 11);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.ShadowDecoration.Parent = this.cmbPeople;
            this.cmbPeople.Size = new System.Drawing.Size(128, 36);
            this.cmbPeople.StartIndex = 0;
            this.cmbPeople.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbPeople.TabIndex = 332;
            this.cmbPeople.SelectedIndexChanged += new System.EventHandler(this.cmbPeople_SelectedIndexChanged);
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
            "Name",
            "City",
            "Contact"});
            this.cmbStatus.ItemsAppearance.Parent = this.cmbStatus;
            this.cmbStatus.Location = new System.Drawing.Point(369, 11);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.ShadowDecoration.Parent = this.cmbStatus;
            this.cmbStatus.Size = new System.Drawing.Size(179, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.TabIndex = 322;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbStatus_SelectionChangeCommitted);
            // 
            // btnNew
            // 
            this.btnNew.Animated = true;
            this.btnNew.AutoRoundedCorners = true;
            this.btnNew.BorderRadius = 18;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.FillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(18, 18);
            this.btnNew.Location = new System.Drawing.Point(148, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(140, 38);
            this.btnNew.TabIndex = 316;
            this.btnNew.Text = "ADD NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnRefresh.ForeColor = System.Drawing.Color.DeepPink;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(966, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 324;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(292, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 323;
            this.label2.Text = "Search By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtSearch.Location = new System.Drawing.Point(554, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Your Contacts Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(281, 36);
            this.txtSearch.TabIndex = 321;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // people_id
            // 
            this.people_id.DataPropertyName = "people_id";
            this.people_id.FillWeight = 20F;
            this.people_id.HeaderText = "#";
            this.people_id.Name = "people_id";
            this.people_id.ReadOnly = true;
            this.people_id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "custom_id";
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cellName
            // 
            this.cellName.DataPropertyName = "name";
            this.cellName.FillWeight = 130F;
            this.cellName.HeaderText = "Name";
            this.cellName.Name = "cellName";
            this.cellName.ReadOnly = true;
            this.cellName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "city";
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "City";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "contact_no";
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Contact No";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "status";
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // cellBalance
            // 
            this.cellBalance.DataPropertyName = "balance";
            dataGridViewCellStyle8.Format = "N2";
            this.cellBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.cellBalance.FillWeight = 60F;
            this.cellBalance.HeaderText = "Balance";
            this.cellBalance.Name = "cellBalance";
            this.cellBalance.ReadOnly = true;
            this.cellBalance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cellAccount
            // 
            this.cellAccount.ActiveLinkColor = System.Drawing.Color.White;
            this.cellAccount.FillWeight = 60F;
            this.cellAccount.HeaderText = "Account";
            this.cellAccount.Name = "cellAccount";
            this.cellAccount.ReadOnly = true;
            this.cellAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellAccount.Text = "View Account";
            this.cellAccount.UseColumnTextForLinkValue = true;
            // 
            // cellPayment
            // 
            this.cellPayment.FillWeight = 50F;
            this.cellPayment.HeaderText = "Payment";
            this.cellPayment.Name = "cellPayment";
            this.cellPayment.ReadOnly = true;
            this.cellPayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellPayment.Text = "Payment";
            this.cellPayment.UseColumnTextForLinkValue = true;
            // 
            // chipOutstanding
            // 
            this.chipOutstanding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chipOutstanding.BorderRadius = 5;
            this.chipOutstanding.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.chipOutstanding.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chipOutstanding.ForeColor = System.Drawing.Color.White;
            this.chipOutstanding.Location = new System.Drawing.Point(843, 7);
            this.chipOutstanding.Name = "chipOutstanding";
            this.chipOutstanding.ShadowDecoration.Parent = this.chipOutstanding;
            this.chipOutstanding.Size = new System.Drawing.Size(169, 35);
            this.chipOutstanding.TabIndex = 354;
            this.chipOutstanding.TabStop = false;
            this.chipOutstanding.Text = "0";
            this.chipOutstanding.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 353;
            this.label3.Text = "Total Outstanding";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 353;
            this.label1.Text = "Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chipCount
            // 
            this.chipCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chipCount.BorderRadius = 5;
            this.chipCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.chipCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chipCount.ForeColor = System.Drawing.Color.White;
            this.chipCount.Location = new System.Drawing.Point(619, 7);
            this.chipCount.Name = "chipCount";
            this.chipCount.ShadowDecoration.Parent = this.chipCount;
            this.chipCount.Size = new System.Drawing.Size(85, 35);
            this.chipCount.TabIndex = 354;
            this.chipCount.TabStop = false;
            this.chipCount.Text = "0";
            this.chipCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ucPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "ucPeople";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1031, 487);
            this.Load += new System.EventHandler(this.ucPeople_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.DataGridView dgvPeople;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefresh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeople;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn people_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn cellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewLinkColumn cellBalance;
        private System.Windows.Forms.DataGridViewLinkColumn cellAccount;
        private System.Windows.Forms.DataGridViewLinkColumn cellPayment;
        private Guna.UI2.WinForms.Guna2Chip chipCount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Chip chipOutstanding;
        private System.Windows.Forms.Label label3;
    }
}
