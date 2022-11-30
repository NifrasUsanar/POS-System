namespace POS_System
{
    partial class ucUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageUser = new System.Windows.Forms.TabPage();
            this.pageLog = new System.Windows.Forms.TabPage();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnedit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUserRole = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dgvUserLog = new System.Windows.Forms.DataGridView();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserLog = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageUser.SuspendLayout();
            this.pageLog.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlView);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(5, 51);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(820, 370);
            this.pnlContainer.TabIndex = 9;
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.tabControl);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(820, 370);
            this.pnlView.TabIndex = 3;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.ColumnHeadersHeight = 35;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.Column3,
            this.user_username,
            this.user_type,
            this.email,
            this.contact,
            this.Column2,
            this.Column1});
            this.dgvUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.NullValue = "...";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.GridColor = System.Drawing.Color.White;
            this.dgvUser.Location = new System.Drawing.Point(6, 46);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUser.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowTemplate.DividerHeight = 1;
            this.dgvUser.RowTemplate.Height = 30;
            this.dgvUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.ShowCellToolTips = false;
            this.dgvUser.Size = new System.Drawing.Size(800, 295);
            this.dgvUser.TabIndex = 310;
            this.dgvUser.TabStop = false;
            // 
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userid.DataPropertyName = "user_id";
            this.userid.FillWeight = 20F;
            this.userid.Frozen = true;
            this.userid.HeaderText = "#";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            this.userid.Width = 26;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "user_name";
            this.Column3.HeaderText = "User";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // user_username
            // 
            this.user_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.user_username.DataPropertyName = "user_username";
            this.user_username.HeaderText = "User Name";
            this.user_username.Name = "user_username";
            this.user_username.ReadOnly = true;
            this.user_username.Width = 128;
            // 
            // user_type
            // 
            this.user_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.user_type.DataPropertyName = "role";
            this.user_type.FillWeight = 50F;
            this.user_type.HeaderText = "User Role";
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            this.user_type.Width = 128;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-Mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 128;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "Contact No";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "created_at";
            this.Column2.HeaderText = "Created";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "is_active";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Is Active";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageUser);
            this.tabControl.Controls.Add(this.pageLog);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 370);
            this.tabControl.TabIndex = 311;
            // 
            // pageUser
            // 
            this.pageUser.Controls.Add(this.btnUserRole);
            this.pageUser.Controls.Add(this.dgvUser);
            this.pageUser.Controls.Add(this.btnedit);
            this.pageUser.Controls.Add(this.btnNew);
            this.pageUser.Location = new System.Drawing.Point(4, 22);
            this.pageUser.Name = "pageUser";
            this.pageUser.Padding = new System.Windows.Forms.Padding(3);
            this.pageUser.Size = new System.Drawing.Size(812, 344);
            this.pageUser.TabIndex = 0;
            this.pageUser.Text = "pageUser";
            this.pageUser.UseVisualStyleBackColor = true;
            // 
            // pageLog
            // 
            this.pageLog.Controls.Add(this.dtpStart);
            this.pageLog.Controls.Add(this.dtpEnd);
            this.pageLog.Controls.Add(this.btnSearch);
            this.pageLog.Controls.Add(this.label4);
            this.pageLog.Controls.Add(this.dgvUserLog);
            this.pageLog.Location = new System.Drawing.Point(4, 22);
            this.pageLog.Name = "pageLog";
            this.pageLog.Padding = new System.Windows.Forms.Padding(3);
            this.pageLog.Size = new System.Drawing.Size(812, 344);
            this.pageLog.TabIndex = 1;
            this.pageLog.Text = "pageUserLog";
            this.pageLog.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Animated = true;
            this.btnNew.BorderRadius = 5;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.FillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(18, 18);
            this.btnNew.Location = new System.Drawing.Point(8, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(115, 36);
            this.btnNew.TabIndex = 315;
            this.btnNew.Text = "Add User";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Animated = true;
            this.btnedit.BorderRadius = 5;
            this.btnedit.CheckedState.Parent = this.btnedit;
            this.btnedit.CustomImages.Parent = this.btnedit;
            this.btnedit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.HoverState.Parent = this.btnedit;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageSize = new System.Drawing.Size(18, 18);
            this.btnedit.Location = new System.Drawing.Point(126, 6);
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Parent = this.btnedit;
            this.btnedit.Size = new System.Drawing.Size(108, 36);
            this.btnedit.TabIndex = 315;
            this.btnedit.Text = "Edit User";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.Location = new System.Drawing.Point(493, 5);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search Here";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.BorderRadius = 10;
            this.guna2TextBox1.ShadowDecoration.Depth = 1;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(322, 36);
            this.guna2TextBox1.TabIndex = 316;
            this.guna2TextBox1.Visible = false;
            // 
            // btnUserRole
            // 
            this.btnUserRole.Animated = true;
            this.btnUserRole.BorderRadius = 5;
            this.btnUserRole.CheckedState.Parent = this.btnUserRole;
            this.btnUserRole.CustomImages.Parent = this.btnUserRole;
            this.btnUserRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnUserRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUserRole.ForeColor = System.Drawing.Color.White;
            this.btnUserRole.HoverState.Parent = this.btnUserRole;
            this.btnUserRole.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRole.Image")));
            this.btnUserRole.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUserRole.Location = new System.Drawing.Point(237, 6);
            this.btnUserRole.Name = "btnUserRole";
            this.btnUserRole.ShadowDecoration.Parent = this.btnUserRole;
            this.btnUserRole.Size = new System.Drawing.Size(116, 36);
            this.btnUserRole.TabIndex = 317;
            this.btnUserRole.Text = "User Role";
            this.btnUserRole.Click += new System.EventHandler(this.btnUserRole_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnUserLog);
            this.pnlTop.Controls.Add(this.btnUser);
            this.pnlTop.Controls.Add(this.guna2TextBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(5, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTop.Size = new System.Drawing.Size(820, 46);
            this.pnlTop.TabIndex = 8;
            // 
            // dgvUserLog
            // 
            this.dgvUserLog.AllowUserToAddRows = false;
            this.dgvUserLog.AllowUserToDeleteRows = false;
            this.dgvUserLog.AllowUserToResizeColumns = false;
            this.dgvUserLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUserLog.ColumnHeadersHeight = 35;
            this.dgvUserLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column4,
            this.Column5});
            this.dgvUserLog.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle9.NullValue = "...";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserLog.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUserLog.EnableHeadersVisualStyles = false;
            this.dgvUserLog.GridColor = System.Drawing.Color.White;
            this.dgvUserLog.Location = new System.Drawing.Point(6, 58);
            this.dgvUserLog.MultiSelect = false;
            this.dgvUserLog.Name = "dgvUserLog";
            this.dgvUserLog.ReadOnly = true;
            this.dgvUserLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUserLog.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUserLog.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUserLog.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUserLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUserLog.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvUserLog.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUserLog.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUserLog.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLog.RowTemplate.DividerHeight = 1;
            this.dgvUserLog.RowTemplate.Height = 30;
            this.dgvUserLog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserLog.ShowCellToolTips = false;
            this.dgvUserLog.Size = new System.Drawing.Size(800, 280);
            this.dgvUserLog.TabIndex = 311;
            this.dgvUserLog.TabStop = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Animated = true;
            this.dtpStart.BackColor = System.Drawing.Color.White;
            this.dtpStart.BorderRadius = 5;
            this.dtpStart.CheckedState.Parent = this.dtpStart;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.HoverState.Parent = this.dtpStart;
            this.dtpStart.Location = new System.Drawing.Point(456, 13);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(131, 36);
            this.dtpStart.TabIndex = 334;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Animated = true;
            this.dtpEnd.BackColor = System.Drawing.Color.White;
            this.dtpEnd.BorderRadius = 5;
            this.dtpEnd.CheckedState.Parent = this.dtpEnd;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.White;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.HoverState.Parent = this.dtpEnd;
            this.dtpEnd.Location = new System.Drawing.Point(625, 13);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(135, 36);
            this.dtpEnd.TabIndex = 333;
            this.dtpEnd.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
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
            this.btnSearch.Location = new System.Drawing.Point(764, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 336;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(589, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 40);
            this.label4.TabIndex = 335;
            this.label4.Text = "TO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUser
            // 
            this.btnUser.Animated = true;
            this.btnUser.BorderRadius = 5;
            this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUser.Checked = true;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUser.Location = new System.Drawing.Point(8, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(116, 36);
            this.btnUser.TabIndex = 317;
            this.btnUser.Text = "VIEW USER";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnUserLog
            // 
            this.btnUserLog.Animated = true;
            this.btnUserLog.BorderRadius = 5;
            this.btnUserLog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUserLog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnUserLog.CheckedState.Parent = this.btnUserLog;
            this.btnUserLog.CustomImages.Parent = this.btnUserLog;
            this.btnUserLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUserLog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUserLog.ForeColor = System.Drawing.Color.White;
            this.btnUserLog.HoverState.Parent = this.btnUserLog;
            this.btnUserLog.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUserLog.Location = new System.Drawing.Point(129, 4);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.ShadowDecoration.Parent = this.btnUserLog;
            this.btnUserLog.Size = new System.Drawing.Size(158, 36);
            this.btnUserLog.TabIndex = 317;
            this.btnUserLog.Text = "USER LOG DETAILS";
            this.btnUserLog.Click += new System.EventHandler(this.btnUserLog_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "User";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_username";
            this.dataGridViewTextBoxColumn3.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 128;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "log_type";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "log_time";
            dataGridViewCellStyle8.Format = "f";
            dataGridViewCellStyle8.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "Date & Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucUser";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(830, 426);
            this.Load += new System.EventHandler(this.ucUser_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageUser.ResumeLayout(false);
            this.pageLog.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageUser;
        private Guna.UI2.WinForms.Guna2Button btnUserRole;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.TabPage pageLog;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvUserLog;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnUserLog;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
