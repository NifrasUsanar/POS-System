namespace POS_System
{
    partial class frmCashRegisterDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashRegisterDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpening = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegisterClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCashinHand = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblRegisterDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCashRegister = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCashIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCashOut = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.grpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = null;
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
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Location = new System.Drawing.Point(1020, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 18;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.guna2Chip1.Size = new System.Drawing.Size(1067, 54);
            this.guna2Chip1.TabIndex = 17;
            this.guna2Chip1.Text = "Cash Register";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 352;
            this.label1.Text = "Opening Cash";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOpening
            // 
            this.txtOpening.Animated = true;
            this.txtOpening.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtOpening.BorderRadius = 5;
            this.txtOpening.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpening.DefaultText = "0";
            this.txtOpening.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOpening.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOpening.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOpening.DisabledState.Parent = this.txtOpening;
            this.txtOpening.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOpening.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOpening.FocusedState.Parent = this.txtOpening;
            this.txtOpening.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtOpening.ForeColor = System.Drawing.Color.Black;
            this.txtOpening.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOpening.HoverState.Parent = this.txtOpening;
            this.txtOpening.Location = new System.Drawing.Point(172, 198);
            this.txtOpening.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpening.Name = "txtOpening";
            this.txtOpening.PasswordChar = '\0';
            this.txtOpening.PlaceholderText = "";
            this.txtOpening.ReadOnly = true;
            this.txtOpening.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOpening.SelectedText = "";
            this.txtOpening.SelectionStart = 1;
            this.txtOpening.ShadowDecoration.Parent = this.txtOpening;
            this.txtOpening.Size = new System.Drawing.Size(188, 35);
            this.txtOpening.TabIndex = 351;
            this.txtOpening.Tag = "";
            // 
            // btnRegisterClose
            // 
            this.btnRegisterClose.Animated = true;
            this.btnRegisterClose.BorderRadius = 6;
            this.btnRegisterClose.CheckedState.Parent = this.btnRegisterClose;
            this.btnRegisterClose.CustomImages.Parent = this.btnRegisterClose;
            this.btnRegisterClose.Enabled = false;
            this.btnRegisterClose.FillColor = System.Drawing.Color.Crimson;
            this.btnRegisterClose.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnRegisterClose.ForeColor = System.Drawing.Color.White;
            this.btnRegisterClose.HoverState.Parent = this.btnRegisterClose;
            this.btnRegisterClose.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRegisterClose.Location = new System.Drawing.Point(12, 459);
            this.btnRegisterClose.Name = "btnRegisterClose";
            this.btnRegisterClose.ShadowDecoration.Parent = this.btnRegisterClose;
            this.btnRegisterClose.Size = new System.Drawing.Size(370, 45);
            this.btnRegisterClose.TabIndex = 353;
            this.btnRegisterClose.Text = "Close Register";
            this.btnRegisterClose.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnRegisterClose.Click += new System.EventHandler(this.btnRegisterClose_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(2, 241);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(365, 10);
            this.guna2Separator1.TabIndex = 355;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 352;
            this.label8.Text = "Cash in Hand";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCashinHand
            // 
            this.txtCashinHand.Animated = true;
            this.txtCashinHand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtCashinHand.BorderRadius = 5;
            this.txtCashinHand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashinHand.DefaultText = "0";
            this.txtCashinHand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCashinHand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCashinHand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashinHand.DisabledState.Parent = this.txtCashinHand;
            this.txtCashinHand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashinHand.FillColor = System.Drawing.SystemColors.Highlight;
            this.txtCashinHand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashinHand.FocusedState.Parent = this.txtCashinHand;
            this.txtCashinHand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtCashinHand.ForeColor = System.Drawing.Color.White;
            this.txtCashinHand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashinHand.HoverState.Parent = this.txtCashinHand;
            this.txtCashinHand.Location = new System.Drawing.Point(171, 265);
            this.txtCashinHand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashinHand.Name = "txtCashinHand";
            this.txtCashinHand.PasswordChar = '\0';
            this.txtCashinHand.PlaceholderText = "";
            this.txtCashinHand.ReadOnly = true;
            this.txtCashinHand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCashinHand.SelectedText = "";
            this.txtCashinHand.SelectionStart = 1;
            this.txtCashinHand.ShadowDecoration.Parent = this.txtCashinHand;
            this.txtCashinHand.Size = new System.Drawing.Size(189, 35);
            this.txtCashinHand.TabIndex = 351;
            this.txtCashinHand.Tag = "";
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Location = new System.Drawing.Point(2, 177);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(365, 10);
            this.guna2Separator6.TabIndex = 355;
            // 
            // lblRegisterDetails
            // 
            this.lblRegisterDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegisterDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterDetails.Location = new System.Drawing.Point(10, 89);
            this.lblRegisterDetails.Name = "lblRegisterDetails";
            this.lblRegisterDetails.Size = new System.Drawing.Size(350, 80);
            this.lblRegisterDetails.TabIndex = 352;
            this.lblRegisterDetails.Text = "Register Opened at: (Fri 9 Oct 2020 @ 02:24 AM by Admin)";
            this.lblRegisterDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRegisterDetails);
            this.groupBox1.Controls.Add(this.cmbCashRegister);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.guna2Separator6);
            this.groupBox1.Controls.Add(this.guna2Separator1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCashinHand);
            this.groupBox1.Controls.Add(this.txtOpening);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 320);
            this.groupBox1.TabIndex = 356;
            this.groupBox1.TabStop = false;
            // 
            // cmbCashRegister
            // 
            this.cmbCashRegister.Animated = true;
            this.cmbCashRegister.BackColor = System.Drawing.Color.Transparent;
            this.cmbCashRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbCashRegister.BorderRadius = 5;
            this.cmbCashRegister.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCashRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashRegister.Enabled = false;
            this.cmbCashRegister.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCashRegister.FocusedState.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCashRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCashRegister.FormattingEnabled = true;
            this.cmbCashRegister.HoverState.Parent = this.cmbCashRegister;
            this.cmbCashRegister.ItemHeight = 30;
            this.cmbCashRegister.ItemsAppearance.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Location = new System.Drawing.Point(6, 40);
            this.cmbCashRegister.Name = "cmbCashRegister";
            this.cmbCashRegister.ShadowDecoration.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Size = new System.Drawing.Size(354, 36);
            this.cmbCashRegister.TabIndex = 357;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(326, 23);
            this.label11.TabIndex = 358;
            this.label11.Text = "Choose and Select a Register (Admin Only)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote
            // 
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
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(14, 414);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.ReadOnly = true;
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(368, 38);
            this.txtNote.TabIndex = 351;
            this.txtNote.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 352;
            this.label10.Text = "Note";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.AllowUserToResizeColumns = false;
            this.dgvRegister.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRegister.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegister.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegister.ColumnHeadersHeight = 35;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.NullValue = "...";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegister.EnableHeadersVisualStyles = false;
            this.dgvRegister.GridColor = System.Drawing.Color.White;
            this.dgvRegister.Location = new System.Drawing.Point(390, 149);
            this.dgvRegister.MultiSelect = false;
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegister.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegister.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegister.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegister.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegister.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRegister.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvRegister.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRegister.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRegister.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegister.RowTemplate.DividerHeight = 1;
            this.dgvRegister.RowTemplate.Height = 30;
            this.dgvRegister.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.ShowCellToolTips = false;
            this.dgvRegister.Size = new System.Drawing.Size(665, 355);
            this.dgvRegister.TabIndex = 357;
            this.dgvRegister.TabStop = false;
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.txtAmount);
            this.grpRegister.Controls.Add(this.txtDescription);
            this.grpRegister.Controls.Add(this.btnCashIn);
            this.grpRegister.Controls.Add(this.btnCashOut);
            this.grpRegister.Controls.Add(this.label3);
            this.grpRegister.Controls.Add(this.label2);
            this.grpRegister.Location = new System.Drawing.Point(390, 60);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(665, 83);
            this.grpRegister.TabIndex = 358;
            this.grpRegister.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtAmount.BorderRadius = 5;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "0";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(347, 37);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionStart = 1;
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(101, 35);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Tag = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
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
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(9, 37);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Description";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(328, 35);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Tag = "";
            // 
            // btnCashIn
            // 
            this.btnCashIn.Animated = true;
            this.btnCashIn.BorderRadius = 6;
            this.btnCashIn.CheckedState.Parent = this.btnCashIn;
            this.btnCashIn.CustomImages.Parent = this.btnCashIn;
            this.btnCashIn.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCashIn.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCashIn.ForeColor = System.Drawing.Color.White;
            this.btnCashIn.HoverState.Parent = this.btnCashIn;
            this.btnCashIn.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCashIn.Location = new System.Drawing.Point(561, 36);
            this.btnCashIn.Name = "btnCashIn";
            this.btnCashIn.ShadowDecoration.Parent = this.btnCashIn;
            this.btnCashIn.Size = new System.Drawing.Size(93, 37);
            this.btnCashIn.TabIndex = 3;
            this.btnCashIn.Text = "Cash in";
            this.btnCashIn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCashIn.Click += new System.EventHandler(this.btnCashIn_Click);
            // 
            // btnCashOut
            // 
            this.btnCashOut.Animated = true;
            this.btnCashOut.BorderRadius = 6;
            this.btnCashOut.CheckedState.Parent = this.btnCashOut;
            this.btnCashOut.CustomImages.Parent = this.btnCashOut;
            this.btnCashOut.FillColor = System.Drawing.Color.Crimson;
            this.btnCashOut.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCashOut.ForeColor = System.Drawing.Color.White;
            this.btnCashOut.HoverState.Parent = this.btnCashOut;
            this.btnCashOut.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCashOut.Location = new System.Drawing.Point(455, 36);
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.ShadowDecoration.Parent = this.btnCashOut;
            this.btnCashOut.Size = new System.Drawing.Size(98, 37);
            this.btnCashOut.TabIndex = 2;
            this.btnCashOut.Text = "Cash Out";
            this.btnCashOut.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnCashOut.Click += new System.EventHandler(this.btnCashOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 352;
            this.label3.Text = "Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 352;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "description";
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "amount";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "detail";
            this.Column3.HeaderText = "Details";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmCashRegisterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.grpRegister);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegisterClose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dgvRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCashRegisterDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.frmCashRegisterDetails_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2TextBox txtOpening;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnRegisterClose;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtCashinHand;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private System.Windows.Forms.Label lblRegisterDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCashRegister;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.GroupBox grpRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCashIn;
        private Guna.UI2.WinForms.Guna2Button btnCashOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}