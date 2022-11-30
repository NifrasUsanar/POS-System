namespace POS_System
{
    partial class frmBanktransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanktransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page = new System.Windows.Forms.TabPage();
            this.toggleCheque = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnCheque = new Guna.UI2.WinForms.Guna2Button();
            this.btnWihtdrawal = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.dgvBankTransfer = new System.Windows.Forms.DataGridView();
            this.cellReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabControl1.SuspendLayout();
            this.page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransfer)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.page);
            this.tabControl1.Location = new System.Drawing.Point(19, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // page
            // 
            this.page.BackColor = System.Drawing.Color.White;
            this.page.Controls.Add(this.toggleCheque);
            this.page.Controls.Add(this.btnCheque);
            this.page.Controls.Add(this.btnWihtdrawal);
            this.page.Controls.Add(this.btnDeposit);
            this.page.Controls.Add(this.label5);
            this.page.Controls.Add(this.dtpDate);
            this.page.Controls.Add(this.txtDescription);
            this.page.Controls.Add(this.txtAmount);
            this.page.Controls.Add(this.label2);
            this.page.Controls.Add(this.label1);
            this.page.Controls.Add(this.label4);
            this.page.Controls.Add(this.lblAccountNo);
            this.page.Controls.Add(this.lblBankName);
            this.page.Location = new System.Drawing.Point(4, 22);
            this.page.Name = "page";
            this.page.Padding = new System.Windows.Forms.Padding(3);
            this.page.Size = new System.Drawing.Size(347, 530);
            this.page.TabIndex = 0;
            this.page.Text = "Deposit";
            // 
            // toggleCheque
            // 
            this.toggleCheque.Animated = true;
            this.toggleCheque.AutoRoundedCorners = true;
            this.toggleCheque.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleCheque.CheckedState.BorderRadius = 13;
            this.toggleCheque.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleCheque.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleCheque.CheckedState.InnerBorderRadius = 9;
            this.toggleCheque.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleCheque.CheckedState.Parent = this.toggleCheque;
            this.toggleCheque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleCheque.Location = new System.Drawing.Point(15, 111);
            this.toggleCheque.Name = "toggleCheque";
            this.toggleCheque.ShadowDecoration.Parent = this.toggleCheque;
            this.toggleCheque.Size = new System.Drawing.Size(54, 28);
            this.toggleCheque.TabIndex = 361;
            this.toggleCheque.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleCheque.UncheckedState.BorderRadius = 13;
            this.toggleCheque.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleCheque.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleCheque.UncheckedState.InnerBorderRadius = 9;
            this.toggleCheque.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleCheque.UncheckedState.Parent = this.toggleCheque;
            this.toggleCheque.CheckedChanged += new System.EventHandler(this.toggleCheque_CheckedChanged);
            // 
            // btnCheque
            // 
            this.btnCheque.Animated = true;
            this.btnCheque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCheque.BorderRadius = 5;
            this.btnCheque.BorderThickness = 1;
            this.btnCheque.CheckedState.Parent = this.btnCheque;
            this.btnCheque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheque.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCheque.CustomImages.Parent = this.btnCheque;
            this.btnCheque.Enabled = false;
            this.btnCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnCheque.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCheque.ForeColor = System.Drawing.Color.White;
            this.btnCheque.HoverState.Parent = this.btnCheque;
            this.btnCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnCheque.Image")));
            this.btnCheque.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheque.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCheque.Location = new System.Drawing.Point(73, 106);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.ShadowDecoration.Parent = this.btnCheque;
            this.btnCheque.Size = new System.Drawing.Size(259, 37);
            this.btnCheque.TabIndex = 360;
            this.btnCheque.Tag = "0";
            this.btnCheque.Text = "select your cheque";
            this.btnCheque.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCheque.TextChanged += new System.EventHandler(this.btnCheque_TextChanged);
            this.btnCheque.Click += new System.EventHandler(this.btnCheque_Click);
            // 
            // btnWihtdrawal
            // 
            this.btnWihtdrawal.Animated = true;
            this.btnWihtdrawal.BorderRadius = 6;
            this.btnWihtdrawal.CheckedState.Parent = this.btnWihtdrawal;
            this.btnWihtdrawal.CustomImages.Parent = this.btnWihtdrawal;
            this.btnWihtdrawal.FillColor = System.Drawing.Color.Crimson;
            this.btnWihtdrawal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnWihtdrawal.ForeColor = System.Drawing.Color.White;
            this.btnWihtdrawal.HoverState.Parent = this.btnWihtdrawal;
            this.btnWihtdrawal.Location = new System.Drawing.Point(15, 458);
            this.btnWihtdrawal.Name = "btnWihtdrawal";
            this.btnWihtdrawal.ShadowDecoration.Parent = this.btnWihtdrawal;
            this.btnWihtdrawal.Size = new System.Drawing.Size(153, 43);
            this.btnWihtdrawal.TabIndex = 357;
            this.btnWihtdrawal.Text = "WITHDRAWAL";
            this.btnWihtdrawal.Click += new System.EventHandler(this.btnWihtdrawal_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Animated = true;
            this.btnDeposit.BorderRadius = 6;
            this.btnDeposit.CheckedState.Parent = this.btnDeposit;
            this.btnDeposit.CustomImages.Parent = this.btnDeposit;
            this.btnDeposit.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.HoverState.Parent = this.btnDeposit;
            this.btnDeposit.Location = new System.Drawing.Point(179, 458);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.ShadowDecoration.Parent = this.btnDeposit;
            this.btnDeposit.Size = new System.Drawing.Size(153, 43);
            this.btnDeposit.TabIndex = 357;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 358;
            this.label5.Text = "Cheque Deposit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Animated = true;
            this.dtpDate.BorderColor = System.Drawing.Color.White;
            this.dtpDate.BorderRadius = 6;
            this.dtpDate.BorderThickness = 1;
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(11, 385);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(321, 40);
            this.dtpDate.TabIndex = 356;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDate.Value = new System.DateTime(2020, 10, 1, 23, 46, 43, 945);
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.BorderRadius = 5;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(11, 252);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(321, 92);
            this.txtDescription.TabIndex = 342;
            this.txtDescription.Tag = "";
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.BorderColor = System.Drawing.Color.Silver;
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
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(11, 181);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(321, 33);
            this.txtAmount.TabIndex = 342;
            this.txtAmount.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 343;
            this.label2.Text = "Description *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 343;
            this.label1.Text = "Date *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 343;
            this.label4.Text = "Amount *";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccountNo.Location = new System.Drawing.Point(6, 38);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(326, 36);
            this.lblAccountNo.TabIndex = 6;
            this.lblAccountNo.Text = "Bank Account Number";
            this.lblAccountNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBankName
            // 
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBankName.Location = new System.Drawing.Point(6, 7);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(326, 28);
            this.lblBankName.TabIndex = 6;
            this.lblBankName.Text = "Bank Name";
            this.lblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
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
            this.guna2Chip1.Size = new System.Drawing.Size(1036, 54);
            this.guna2Chip1.TabIndex = 353;
            this.guna2Chip1.Text = "Bank Cash Transfer Details";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dgvBankTransfer
            // 
            this.dgvBankTransfer.AllowUserToAddRows = false;
            this.dgvBankTransfer.AllowUserToDeleteRows = false;
            this.dgvBankTransfer.AllowUserToResizeColumns = false;
            this.dgvBankTransfer.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBankTransfer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBankTransfer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBankTransfer.BackgroundColor = System.Drawing.Color.White;
            this.dgvBankTransfer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBankTransfer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBankTransfer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankTransfer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBankTransfer.ColumnHeadersHeight = 35;
            this.dgvBankTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBankTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellReference,
            this.cellTransactionID,
            this.Column3,
            this.description,
            this.cellAmount,
            this.transaction_type,
            this.Created_by,
            this.cellDelete});
            this.dgvBankTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle16.NullValue = "...";
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankTransfer.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvBankTransfer.EnableHeadersVisualStyles = false;
            this.dgvBankTransfer.GridColor = System.Drawing.Color.White;
            this.dgvBankTransfer.Location = new System.Drawing.Point(385, 126);
            this.dgvBankTransfer.MultiSelect = false;
            this.dgvBankTransfer.Name = "dgvBankTransfer";
            this.dgvBankTransfer.ReadOnly = true;
            this.dgvBankTransfer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankTransfer.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvBankTransfer.RowHeadersVisible = false;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBankTransfer.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBankTransfer.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankTransfer.RowTemplate.DividerHeight = 1;
            this.dgvBankTransfer.RowTemplate.Height = 30;
            this.dgvBankTransfer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankTransfer.ShowCellToolTips = false;
            this.dgvBankTransfer.Size = new System.Drawing.Size(628, 476);
            this.dgvBankTransfer.TabIndex = 354;
            this.dgvBankTransfer.TabStop = false;
            this.dgvBankTransfer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBankTransfer_CellContentClick);
            // 
            // cellReference
            // 
            this.cellReference.DataPropertyName = "refrence_id";
            this.cellReference.HeaderText = "reference_id";
            this.cellReference.Name = "cellReference";
            this.cellReference.ReadOnly = true;
            this.cellReference.Visible = false;
            // 
            // cellTransactionID
            // 
            this.cellTransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cellTransactionID.DataPropertyName = "id";
            this.cellTransactionID.FillWeight = 20F;
            this.cellTransactionID.HeaderText = "#";
            this.cellTransactionID.Name = "cellTransactionID";
            this.cellTransactionID.ReadOnly = true;
            this.cellTransactionID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellTransactionID.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "date";
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.FillWeight = 80F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // cellAmount
            // 
            this.cellAmount.DataPropertyName = "amount";
            this.cellAmount.FillWeight = 50F;
            this.cellAmount.HeaderText = "Amount";
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.ReadOnly = true;
            // 
            // transaction_type
            // 
            this.transaction_type.DataPropertyName = "transaction_type";
            this.transaction_type.FillWeight = 50F;
            this.transaction_type.HeaderText = "Type";
            this.transaction_type.Name = "transaction_type";
            this.transaction_type.ReadOnly = true;
            // 
            // Created_by
            // 
            this.Created_by.DataPropertyName = "user_name";
            this.Created_by.FillWeight = 60F;
            this.Created_by.HeaderText = "User";
            this.Created_by.Name = "Created_by";
            this.Created_by.ReadOnly = true;
            // 
            // cellDelete
            // 
            this.cellDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.NullValue = null;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.cellDelete.DefaultCellStyle = dataGridViewCellStyle15;
            this.cellDelete.FillWeight = 20F;
            this.cellDelete.HeaderText = "";
            this.cellDelete.Name = "cellDelete";
            this.cellDelete.ReadOnly = true;
            this.cellDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cellDelete.Text = "X";
            this.cellDelete.UseColumnTextForButtonValue = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Location = new System.Drawing.Point(989, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 357;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel2.Controls.Add(this.txtSearch);
            this.guna2Panel2.Controls.Add(this.btnSearch);
            this.guna2Panel2.Controls.Add(this.dtpStart);
            this.guna2Panel2.Controls.Add(this.dtpEnd);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(385, 66);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(628, 58);
            this.guna2Panel2.TabIndex = 359;
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 6;
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
            this.txtSearch.Location = new System.Drawing.Point(7, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(269, 40);
            this.txtSearch.TabIndex = 364;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(579, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 363;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Animated = true;
            this.dtpStart.BackColor = System.Drawing.Color.White;
            this.dtpStart.BorderRadius = 6;
            this.dtpStart.CheckedState.Parent = this.dtpStart;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.HoverState.Parent = this.dtpStart;
            this.dtpStart.Location = new System.Drawing.Point(297, 10);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(123, 40);
            this.dtpStart.TabIndex = 360;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            this.dtpStart.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Animated = true;
            this.dtpEnd.BackColor = System.Drawing.Color.White;
            this.dtpEnd.BorderRadius = 6;
            this.dtpEnd.CheckedState.Parent = this.dtpEnd;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.White;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.HoverState.Parent = this.dtpEnd;
            this.dtpEnd.Location = new System.Drawing.Point(455, 10);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(117, 40);
            this.dtpEnd.TabIndex = 361;
            this.dtpEnd.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            this.dtpEnd.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(421, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 40);
            this.label10.TabIndex = 362;
            this.label10.Text = "TO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Visible = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Chip1;
            // 
            // frmBanktransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 614);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvBankTransfer);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBanktransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBanktransfer";
            this.Load += new System.EventHandler(this.frmBanktransfer_Load);
            this.Shown += new System.EventHandler(this.frmBanktransfer_Shown);
            this.tabControl1.ResumeLayout(false);
            this.page.ResumeLayout(false);
            this.page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankTransfer)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private System.Windows.Forms.DataGridView dgvBankTransfer;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblBankName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnWihtdrawal;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Button btnCheque;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleCheque;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaction_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_by;
        private System.Windows.Forms.DataGridViewButtonColumn cellDelete;
    }
}