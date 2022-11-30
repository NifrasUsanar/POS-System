namespace POS_System
{
    partial class frmCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheque));
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtChequeNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBank = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpChequeDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cmbAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPartyCheque = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChequeTO = new System.Windows.Forms.Label();
            this.lblChequeFrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPartyChequeReturn = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.grpPartyCheque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 0);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(530, 54);
            this.guna2Chip1.TabIndex = 10;
            this.guna2Chip1.Text = "View / Edit Cheque";
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
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2CircleButton1.Location = new System.Drawing.Point(483, 10);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(35, 35);
            this.guna2CircleButton1.TabIndex = 11;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Animated = true;
            this.txtChequeNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtChequeNo.BorderRadius = 5;
            this.txtChequeNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChequeNo.DefaultText = "";
            this.txtChequeNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChequeNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChequeNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChequeNo.DisabledState.Parent = this.txtChequeNo;
            this.txtChequeNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChequeNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChequeNo.FocusedState.Parent = this.txtChequeNo;
            this.txtChequeNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtChequeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChequeNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChequeNo.HoverState.Parent = this.txtChequeNo;
            this.txtChequeNo.Location = new System.Drawing.Point(113, 80);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.PasswordChar = '\0';
            this.txtChequeNo.PlaceholderText = "Cheque No";
            this.txtChequeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtChequeNo.SelectedText = "";
            this.txtChequeNo.ShadowDecoration.Parent = this.txtChequeNo;
            this.txtChequeNo.Size = new System.Drawing.Size(364, 35);
            this.txtChequeNo.TabIndex = 322;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 323;
            this.label7.Text = "Cheque No";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBank
            // 
            this.txtBank.Animated = true;
            this.txtBank.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtBank.BorderRadius = 5;
            this.txtBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBank.DefaultText = "";
            this.txtBank.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBank.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBank.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBank.DisabledState.Parent = this.txtBank;
            this.txtBank.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBank.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBank.FocusedState.Parent = this.txtBank;
            this.txtBank.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBank.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBank.HoverState.Parent = this.txtBank;
            this.txtBank.Location = new System.Drawing.Point(113, 186);
            this.txtBank.Margin = new System.Windows.Forms.Padding(4);
            this.txtBank.Name = "txtBank";
            this.txtBank.PasswordChar = '\0';
            this.txtBank.PlaceholderText = "Bank Name";
            this.txtBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBank.SelectedText = "";
            this.txtBank.ShadowDecoration.Parent = this.txtBank;
            this.txtBank.Size = new System.Drawing.Size(364, 35);
            this.txtBank.TabIndex = 322;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 323;
            this.label1.Text = "Bank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.BorderRadius = 8;
            this.dtpChequeDate.CheckedState.Parent = this.dtpChequeDate;
            this.dtpChequeDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpChequeDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpChequeDate.ForeColor = System.Drawing.Color.White;
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChequeDate.HoverState.Parent = this.dtpChequeDate;
            this.dtpChequeDate.Location = new System.Drawing.Point(113, 294);
            this.dtpChequeDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpChequeDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.ShadowDecoration.Parent = this.dtpChequeDate;
            this.dtpChequeDate.Size = new System.Drawing.Size(162, 36);
            this.dtpChequeDate.TabIndex = 325;
            this.dtpChequeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpChequeDate.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // cmbType
            // 
            this.cmbType.Animated = true;
            this.cmbType.BackColor = System.Drawing.Color.Transparent;
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbType.BorderRadius = 5;
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbType.FocusedState.Parent = this.cmbType;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.HoverState.Parent = this.cmbType;
            this.cmbType.ItemHeight = 30;
            this.cmbType.Items.AddRange(new object[] {
            "Post Date",
            "Current Date"});
            this.cmbType.ItemsAppearance.Parent = this.cmbType;
            this.cmbType.Location = new System.Drawing.Point(113, 241);
            this.cmbType.Name = "cmbType";
            this.cmbType.ShadowDecoration.Parent = this.cmbType;
            this.cmbType.Size = new System.Drawing.Size(364, 36);
            this.cmbType.TabIndex = 326;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Animated = true;
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbStatus.BorderRadius = 5;
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
            "Pending",
            "Return",
            "Paid",
            "Cancelled"});
            this.cmbStatus.ItemsAppearance.Parent = this.cmbStatus;
            this.cmbStatus.Location = new System.Drawing.Point(283, 294);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.ShadowDecoration.Parent = this.cmbStatus;
            this.cmbStatus.Size = new System.Drawing.Size(194, 36);
            this.cmbStatus.TabIndex = 326;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 323;
            this.label2.Text = "Cheque Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtAmount.BorderRadius = 5;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(113, 132);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(364, 35);
            this.txtAmount.TabIndex = 322;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 323;
            this.label3.Text = "Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPartyChequeReturn);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.cmbAccount);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.txtChequeNo);
            this.groupBox1.Controls.Add(this.dtpChequeDate);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 451);
            this.groupBox1.TabIndex = 327;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 6;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSave.Location = new System.Drawing.Point(113, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(364, 40);
            this.btnSave.TabIndex = 328;
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAccount
            // 
            this.cmbAccount.Animated = true;
            this.cmbAccount.BackColor = System.Drawing.Color.Transparent;
            this.cmbAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbAccount.BorderRadius = 5;
            this.cmbAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.Enabled = false;
            this.cmbAccount.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAccount.FocusedState.Parent = this.cmbAccount;
            this.cmbAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.HoverState.Parent = this.cmbAccount;
            this.cmbAccount.ItemHeight = 30;
            this.cmbAccount.Items.AddRange(new object[] {
            "Post Date",
            "Current Date"});
            this.cmbAccount.ItemsAppearance.Parent = this.cmbAccount;
            this.cmbAccount.Location = new System.Drawing.Point(113, 26);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.ShadowDecoration.Parent = this.cmbAccount;
            this.cmbAccount.Size = new System.Drawing.Size(364, 36);
            this.cmbAccount.TabIndex = 326;
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 323;
            this.label4.Text = "Account";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpPartyCheque
            // 
            this.grpPartyCheque.Controls.Add(this.label6);
            this.grpPartyCheque.Controls.Add(this.lblChequeTO);
            this.grpPartyCheque.Controls.Add(this.lblChequeFrom);
            this.grpPartyCheque.Controls.Add(this.label5);
            this.grpPartyCheque.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPartyCheque.Location = new System.Drawing.Point(0, 54);
            this.grpPartyCheque.Name = "grpPartyCheque";
            this.grpPartyCheque.Size = new System.Drawing.Size(530, 65);
            this.grpPartyCheque.TabIndex = 328;
            this.grpPartyCheque.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 323;
            this.label6.Text = "Cheque To :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChequeTO
            // 
            this.lblChequeTO.AutoSize = true;
            this.lblChequeTO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeTO.Location = new System.Drawing.Point(273, 37);
            this.lblChequeTO.Name = "lblChequeTO";
            this.lblChequeTO.Size = new System.Drawing.Size(21, 19);
            this.lblChequeTO.TabIndex = 323;
            this.lblChequeTO.Text = "   ";
            this.lblChequeTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChequeFrom
            // 
            this.lblChequeFrom.AutoSize = true;
            this.lblChequeFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeFrom.Location = new System.Drawing.Point(12, 37);
            this.lblChequeFrom.Name = "lblChequeFrom";
            this.lblChequeFrom.Size = new System.Drawing.Size(21, 19);
            this.lblChequeFrom.TabIndex = 323;
            this.lblChequeFrom.Text = "   ";
            this.lblChequeFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 323;
            this.label5.Text = "Cheque From : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 470);
            this.panel1.TabIndex = 329;
            // 
            // btnPartyChequeReturn
            // 
            this.btnPartyChequeReturn.Animated = true;
            this.btnPartyChequeReturn.BorderRadius = 6;
            this.btnPartyChequeReturn.CheckedState.Parent = this.btnPartyChequeReturn;
            this.btnPartyChequeReturn.CustomImages.Parent = this.btnPartyChequeReturn;
            this.btnPartyChequeReturn.FillColor = System.Drawing.Color.Crimson;
            this.btnPartyChequeReturn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPartyChequeReturn.ForeColor = System.Drawing.Color.White;
            this.btnPartyChequeReturn.HoverState.Parent = this.btnPartyChequeReturn;
            this.btnPartyChequeReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnPartyChequeReturn.Image")));
            this.btnPartyChequeReturn.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btnPartyChequeReturn.Location = new System.Drawing.Point(113, 396);
            this.btnPartyChequeReturn.Name = "btnPartyChequeReturn";
            this.btnPartyChequeReturn.ShadowDecoration.Parent = this.btnPartyChequeReturn;
            this.btnPartyChequeReturn.Size = new System.Drawing.Size(364, 40);
            this.btnPartyChequeReturn.TabIndex = 328;
            this.btnPartyChequeReturn.Text = "Party Cheque Return";
            this.btnPartyChequeReturn.TextOffset = new System.Drawing.Point(3, 0);
            this.btnPartyChequeReturn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPartyChequeReturn.Click += new System.EventHandler(this.btnPartyChequeReturn_Click);
            // 
            // frmCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPartyCheque);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheque";
            this.Text = "frmCheque";
            this.Load += new System.EventHandler(this.frmCheque_Load);
            this.Shown += new System.EventHandler(this.frmCheque_Shown);
            this.groupBox1.ResumeLayout(false);
            this.grpPartyCheque.ResumeLayout(false);
            this.grpPartyCheque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtChequeNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBank;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpChequeDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPartyCheque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblChequeTO;
        private System.Windows.Forms.Label lblChequeFrom;
        private Guna.UI2.WinForms.Guna2Button btnPartyChequeReturn;
    }
}