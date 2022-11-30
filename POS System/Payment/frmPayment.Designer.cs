namespace POS_System
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.grpBalance = new System.Windows.Forms.GroupBox();
            this.lblPayable = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chipPayment = new Guna.UI2.WinForms.Guna2Chip();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOtherPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbCheque = new System.Windows.Forms.GroupBox();
            this.pnlChequeInfo = new System.Windows.Forms.Panel();
            this.txtChequeNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbChequeType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCheque = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtBank = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpChequeSupplier = new System.Windows.Forms.GroupBox();
            this.btnPartyCheque = new Guna.UI2.WinForms.Guna2Button();
            this.togglePartyCheque = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.chipAccountBalance = new Guna.UI2.WinForms.Guna2Chip();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAccount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnCash = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheque = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnOther = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpForm.SuspendLayout();
            this.grpBalance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbCheque.SuspendLayout();
            this.pnlChequeInfo.SuspendLayout();
            this.grpChequeSupplier.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnPrint);
            this.grpForm.Controls.Add(this.btnPayment);
            this.grpForm.Controls.Add(this.grpBalance);
            this.grpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpForm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpForm.Location = new System.Drawing.Point(0, 255);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(616, 76);
            this.grpForm.TabIndex = 9;
            this.grpForm.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint.Animated = true;
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrint.ImageSize = new System.Drawing.Size(23, 23);
            this.btnPrint.Location = new System.Drawing.Point(477, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(132, 55);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrint.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnPrint.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPayment.Animated = true;
            this.btnPayment.BorderRadius = 5;
            this.btnPayment.CheckedState.Parent = this.btnPayment;
            this.btnPayment.CustomImages.Parent = this.btnPayment;
            this.btnPayment.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.HoverState.Parent = this.btnPayment;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayment.ImageSize = new System.Drawing.Size(27, 27);
            this.btnPayment.Location = new System.Drawing.Point(343, 14);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.ShadowDecoration.Parent = this.btnPayment;
            this.btnPayment.Size = new System.Drawing.Size(132, 55);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Save";
            this.btnPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPayment.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnPayment.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // grpBalance
            // 
            this.grpBalance.Controls.Add(this.lblPayable);
            this.grpBalance.Controls.Add(this.label10);
            this.grpBalance.Controls.Add(this.lblBalance);
            this.grpBalance.Controls.Add(this.label11);
            this.grpBalance.Location = new System.Drawing.Point(17, 430);
            this.grpBalance.Name = "grpBalance";
            this.grpBalance.Size = new System.Drawing.Size(344, 65);
            this.grpBalance.TabIndex = 345;
            this.grpBalance.TabStop = false;
            // 
            // lblPayable
            // 
            this.lblPayable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayable.Location = new System.Drawing.Point(65, 26);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(87, 19);
            this.lblPayable.TabIndex = 337;
            this.lblPayable.Text = "Rs.0";
            this.lblPayable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPayable.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 337;
            this.label10.Text = "Payable:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(223, 26);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(87, 19);
            this.lblBalance.TabIndex = 337;
            this.lblBalance.Text = "Rs.0";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBalance.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 337;
            this.label11.Text = "Balance:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chipPayment);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtOtherPayment);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(154, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // chipPayment
            // 
            this.chipPayment.BackColor = System.Drawing.Color.White;
            this.chipPayment.BorderRadius = 5;
            this.chipPayment.FillColor = System.Drawing.SystemColors.AppWorkspace;
            this.chipPayment.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.chipPayment.ForeColor = System.Drawing.Color.Black;
            this.chipPayment.Location = new System.Drawing.Point(370, 20);
            this.chipPayment.Name = "chipPayment";
            this.chipPayment.ShadowDecoration.Parent = this.chipPayment;
            this.chipPayment.Size = new System.Drawing.Size(226, 57);
            this.chipPayment.TabIndex = 353;
            this.chipPayment.Text = "Cash";
            this.chipPayment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2HtmlToolTip1.SetToolTip(this.chipPayment, "Account Balance");
            this.chipPayment.TextChanged += new System.EventHandler(this.chipPayment_TextChanged);
            // 
            // txtNote
            // 
            this.txtNote.Animated = true;
            this.txtNote.BorderColor = System.Drawing.Color.Silver;
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
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(86, 137);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "Note";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(510, 33);
            this.txtNote.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Animated = true;
            this.txtAmount.BorderColor = System.Drawing.Color.Silver;
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
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(86, 20);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionStart = 1;
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.ShortcutsEnabled = false;
            this.txtAmount.Size = new System.Drawing.Size(247, 57);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 19);
            this.label9.TabIndex = 337;
            this.label9.Text = "Note";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 337;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 337;
            this.label12.Text = "Description";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOtherPayment
            // 
            this.txtOtherPayment.Animated = true;
            this.txtOtherPayment.BorderColor = System.Drawing.Color.Silver;
            this.txtOtherPayment.BorderRadius = 5;
            this.txtOtherPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOtherPayment.DefaultText = "";
            this.txtOtherPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOtherPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOtherPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtherPayment.DisabledState.Parent = this.txtOtherPayment;
            this.txtOtherPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtherPayment.Enabled = false;
            this.txtOtherPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOtherPayment.FocusedState.Parent = this.txtOtherPayment;
            this.txtOtherPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOtherPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOtherPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOtherPayment.HoverState.Parent = this.txtOtherPayment;
            this.txtOtherPayment.Location = new System.Drawing.Point(86, 87);
            this.txtOtherPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOtherPayment.Name = "txtOtherPayment";
            this.txtOtherPayment.PasswordChar = '\0';
            this.txtOtherPayment.PlaceholderText = "Description";
            this.txtOtherPayment.SelectedText = "";
            this.txtOtherPayment.ShadowDecoration.Parent = this.txtOtherPayment;
            this.txtOtherPayment.Size = new System.Drawing.Size(510, 33);
            this.txtOtherPayment.TabIndex = 336;
            this.txtOtherPayment.Leave += new System.EventHandler(this.txtOtherPayment_Leave);
            // 
            // grbCheque
            // 
            this.grbCheque.Controls.Add(this.pnlChequeInfo);
            this.grbCheque.Controls.Add(this.grpChequeSupplier);
            this.grbCheque.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCheque.Enabled = false;
            this.grbCheque.Location = new System.Drawing.Point(0, 0);
            this.grbCheque.Name = "grbCheque";
            this.grbCheque.Size = new System.Drawing.Size(616, 255);
            this.grbCheque.TabIndex = 5;
            this.grbCheque.TabStop = false;
            this.grbCheque.Text = "Cheque Payment";
            // 
            // pnlChequeInfo
            // 
            this.pnlChequeInfo.Controls.Add(this.txtChequeNo);
            this.pnlChequeInfo.Controls.Add(this.cmbChequeType);
            this.pnlChequeInfo.Controls.Add(this.label4);
            this.pnlChequeInfo.Controls.Add(this.label1);
            this.pnlChequeInfo.Controls.Add(this.dtpCheque);
            this.pnlChequeInfo.Controls.Add(this.txtBank);
            this.pnlChequeInfo.Controls.Add(this.label2);
            this.pnlChequeInfo.Controls.Add(this.label3);
            this.pnlChequeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChequeInfo.Location = new System.Drawing.Point(3, 131);
            this.pnlChequeInfo.Name = "pnlChequeInfo";
            this.pnlChequeInfo.Size = new System.Drawing.Size(610, 121);
            this.pnlChequeInfo.TabIndex = 355;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Animated = true;
            this.txtChequeNo.BorderColor = System.Drawing.Color.Silver;
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
            this.txtChequeNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtChequeNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChequeNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChequeNo.HoverState.Parent = this.txtChequeNo;
            this.txtChequeNo.Location = new System.Drawing.Point(90, 17);
            this.txtChequeNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.PasswordChar = '\0';
            this.txtChequeNo.PlaceholderText = "Cheque Number";
            this.txtChequeNo.SelectedText = "";
            this.txtChequeNo.ShadowDecoration.Parent = this.txtChequeNo;
            this.txtChequeNo.Size = new System.Drawing.Size(212, 33);
            this.txtChequeNo.TabIndex = 1;
            // 
            // cmbChequeType
            // 
            this.cmbChequeType.Animated = true;
            this.cmbChequeType.BackColor = System.Drawing.Color.Transparent;
            this.cmbChequeType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbChequeType.BorderRadius = 5;
            this.cmbChequeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbChequeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChequeType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbChequeType.FocusedState.Parent = this.cmbChequeType;
            this.cmbChequeType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbChequeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbChequeType.FormattingEnabled = true;
            this.cmbChequeType.HoverState.Parent = this.cmbChequeType;
            this.cmbChequeType.ItemHeight = 28;
            this.cmbChequeType.Items.AddRange(new object[] {
            "Post Date",
            "Current Date",
            "Stale Cheque"});
            this.cmbChequeType.ItemsAppearance.Parent = this.cmbChequeType;
            this.cmbChequeType.Location = new System.Drawing.Point(411, 75);
            this.cmbChequeType.Name = "cmbChequeType";
            this.cmbChequeType.ShadowDecoration.Parent = this.cmbChequeType;
            this.cmbChequeType.Size = new System.Drawing.Size(191, 34);
            this.cmbChequeType.StartIndex = 0;
            this.cmbChequeType.TabIndex = 4;
            this.cmbChequeType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 337;
            this.label1.Text = "Cheque No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpCheque
            // 
            this.dtpCheque.Animated = true;
            this.dtpCheque.BorderRadius = 8;
            this.dtpCheque.CheckedState.Parent = this.dtpCheque;
            this.dtpCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpCheque.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpCheque.ForeColor = System.Drawing.Color.White;
            this.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheque.HoverState.Parent = this.dtpCheque;
            this.dtpCheque.Location = new System.Drawing.Point(408, 16);
            this.dtpCheque.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheque.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheque.Name = "dtpCheque";
            this.dtpCheque.ShadowDecoration.Parent = this.dtpCheque;
            this.dtpCheque.Size = new System.Drawing.Size(194, 35);
            this.dtpCheque.TabIndex = 2;
            this.dtpCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpCheque.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // txtBank
            // 
            this.txtBank.Animated = true;
            this.txtBank.BorderColor = System.Drawing.Color.Silver;
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
            this.txtBank.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBank.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBank.HoverState.Parent = this.txtBank;
            this.txtBank.Location = new System.Drawing.Point(90, 76);
            this.txtBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBank.Name = "txtBank";
            this.txtBank.PasswordChar = '\0';
            this.txtBank.PlaceholderText = "Bank Name";
            this.txtBank.SelectedText = "";
            this.txtBank.ShadowDecoration.Parent = this.txtBank;
            this.txtBank.Size = new System.Drawing.Size(212, 33);
            this.txtBank.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 337;
            this.label3.Text = "Bank";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpChequeSupplier
            // 
            this.grpChequeSupplier.Controls.Add(this.btnPartyCheque);
            this.grpChequeSupplier.Controls.Add(this.togglePartyCheque);
            this.grpChequeSupplier.Controls.Add(this.chipAccountBalance);
            this.grpChequeSupplier.Controls.Add(this.label5);
            this.grpChequeSupplier.Controls.Add(this.label7);
            this.grpChequeSupplier.Controls.Add(this.cmbAccount);
            this.grpChequeSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpChequeSupplier.Location = new System.Drawing.Point(3, 16);
            this.grpChequeSupplier.Name = "grpChequeSupplier";
            this.grpChequeSupplier.Size = new System.Drawing.Size(610, 115);
            this.grpChequeSupplier.TabIndex = 354;
            this.grpChequeSupplier.TabStop = false;
            this.grpChequeSupplier.Visible = false;
            // 
            // btnPartyCheque
            // 
            this.btnPartyCheque.Animated = true;
            this.btnPartyCheque.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPartyCheque.BorderRadius = 5;
            this.btnPartyCheque.BorderThickness = 1;
            this.btnPartyCheque.CheckedState.Parent = this.btnPartyCheque;
            this.btnPartyCheque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartyCheque.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPartyCheque.CustomImages.Parent = this.btnPartyCheque;
            this.btnPartyCheque.Enabled = false;
            this.btnPartyCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnPartyCheque.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPartyCheque.ForeColor = System.Drawing.Color.White;
            this.btnPartyCheque.HoverState.Parent = this.btnPartyCheque;
            this.btnPartyCheque.Image = ((System.Drawing.Image)(resources.GetObject("btnPartyCheque.Image")));
            this.btnPartyCheque.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPartyCheque.ImageSize = new System.Drawing.Size(18, 18);
            this.btnPartyCheque.Location = new System.Drawing.Point(175, 67);
            this.btnPartyCheque.Name = "btnPartyCheque";
            this.btnPartyCheque.ShadowDecoration.Parent = this.btnPartyCheque;
            this.btnPartyCheque.Size = new System.Drawing.Size(427, 37);
            this.btnPartyCheque.TabIndex = 354;
            this.btnPartyCheque.Tag = "0";
            this.btnPartyCheque.Text = "select your cheque";
            this.btnPartyCheque.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnPartyCheque.TextChanged += new System.EventHandler(this.btnPartyCheque_TextChanged);
            this.btnPartyCheque.Click += new System.EventHandler(this.btnPartyCheque_Click);
            // 
            // togglePartyCheque
            // 
            this.togglePartyCheque.Animated = true;
            this.togglePartyCheque.AutoRoundedCorners = true;
            this.togglePartyCheque.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePartyCheque.CheckedState.BorderRadius = 13;
            this.togglePartyCheque.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.togglePartyCheque.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePartyCheque.CheckedState.InnerBorderRadius = 9;
            this.togglePartyCheque.CheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePartyCheque.CheckedState.Parent = this.togglePartyCheque;
            this.togglePartyCheque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePartyCheque.Location = new System.Drawing.Point(115, 71);
            this.togglePartyCheque.Name = "togglePartyCheque";
            this.togglePartyCheque.ShadowDecoration.Parent = this.togglePartyCheque;
            this.togglePartyCheque.Size = new System.Drawing.Size(54, 28);
            this.togglePartyCheque.TabIndex = 353;
            this.togglePartyCheque.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePartyCheque.UncheckedState.BorderRadius = 13;
            this.togglePartyCheque.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.togglePartyCheque.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.togglePartyCheque.UncheckedState.InnerBorderRadius = 9;
            this.togglePartyCheque.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.togglePartyCheque.UncheckedState.Parent = this.togglePartyCheque;
            this.togglePartyCheque.CheckedChanged += new System.EventHandler(this.togglePartyCheque_CheckedChanged);
            // 
            // chipAccountBalance
            // 
            this.chipAccountBalance.BackColor = System.Drawing.Color.White;
            this.chipAccountBalance.BorderRadius = 5;
            this.chipAccountBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chipAccountBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.chipAccountBalance.ForeColor = System.Drawing.Color.White;
            this.chipAccountBalance.Location = new System.Drawing.Point(400, 17);
            this.chipAccountBalance.Name = "chipAccountBalance";
            this.chipAccountBalance.ShadowDecoration.Parent = this.chipAccountBalance;
            this.chipAccountBalance.Size = new System.Drawing.Size(202, 34);
            this.chipAccountBalance.TabIndex = 352;
            this.chipAccountBalance.Text = "Rs. 0. 00";
            this.chipAccountBalance.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2HtmlToolTip1.SetToolTip(this.chipAccountBalance, "Account Balance");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 337;
            this.label5.Text = "Party Cheque";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 337;
            this.label7.Text = "Account";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.HoverState.Parent = this.cmbAccount;
            this.cmbAccount.ItemHeight = 28;
            this.cmbAccount.ItemsAppearance.Parent = this.cmbAccount;
            this.cmbAccount.Location = new System.Drawing.Point(86, 17);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.ShadowDecoration.Parent = this.cmbAccount;
            this.cmbAccount.Size = new System.Drawing.Size(308, 34);
            this.cmbAccount.TabIndex = 0;
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
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
            this.btnClose.Location = new System.Drawing.Point(735, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 15;
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
            this.guna2Chip1.Size = new System.Drawing.Size(785, 54);
            this.guna2Chip1.TabIndex = 14;
            this.guna2Chip1.Text = "Payments";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btnCash
            // 
            this.btnCash.Animated = true;
            this.btnCash.BorderRadius = 5;
            this.btnCash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCash.Checked = true;
            this.btnCash.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCash.CheckedState.Parent = this.btnCash;
            this.btnCash.CustomBorderColor = System.Drawing.Color.White;
            this.btnCash.CustomImages.Parent = this.btnCash;
            this.btnCash.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCash.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.HoverState.Parent = this.btnCash;
            this.btnCash.Location = new System.Drawing.Point(3, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.ShadowDecoration.Parent = this.btnCash;
            this.btnCash.Size = new System.Drawing.Size(133, 52);
            this.btnCash.TabIndex = 346;
            this.btnCash.Text = "Cash";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCheque
            // 
            this.btnCheque.Animated = true;
            this.btnCheque.BorderRadius = 5;
            this.btnCheque.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheque.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnCheque.CheckedState.Parent = this.btnCheque;
            this.btnCheque.CustomBorderColor = System.Drawing.Color.White;
            this.btnCheque.CustomImages.Parent = this.btnCheque;
            this.btnCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheque.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCheque.ForeColor = System.Drawing.Color.White;
            this.btnCheque.HoverState.Parent = this.btnCheque;
            this.btnCheque.Location = new System.Drawing.Point(3, 61);
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.ShadowDecoration.Parent = this.btnCheque;
            this.btnCheque.Size = new System.Drawing.Size(133, 52);
            this.btnCheque.TabIndex = 346;
            this.btnCheque.Text = "Cheque";
            this.btnCheque.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCash);
            this.flowLayoutPanel1.Controls.Add(this.btnCheque);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Controls.Add(this.btnOther);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 338);
            this.flowLayoutPanel1.TabIndex = 347;
            // 
            // btnAccount
            // 
            this.btnAccount.Animated = true;
            this.btnAccount.BorderRadius = 5;
            this.btnAccount.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAccount.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAccount.CheckedState.Parent = this.btnAccount;
            this.btnAccount.CustomBorderColor = System.Drawing.Color.White;
            this.btnAccount.CustomImages.Parent = this.btnAccount;
            this.btnAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.HoverState.Parent = this.btnAccount;
            this.btnAccount.Location = new System.Drawing.Point(3, 119);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.ShadowDecoration.Parent = this.btnAccount;
            this.btnAccount.Size = new System.Drawing.Size(133, 52);
            this.btnAccount.TabIndex = 347;
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnOther
            // 
            this.btnOther.Animated = true;
            this.btnOther.BorderRadius = 5;
            this.btnOther.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOther.CheckedState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnOther.CheckedState.Parent = this.btnOther;
            this.btnOther.CustomBorderColor = System.Drawing.Color.White;
            this.btnOther.CustomImages.Parent = this.btnOther;
            this.btnOther.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOther.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.HoverState.Parent = this.btnOther;
            this.btnOther.Location = new System.Drawing.Point(3, 177);
            this.btnOther.Name = "btnOther";
            this.btnOther.ShadowDecoration.Parent = this.btnOther;
            this.btnOther.Size = new System.Drawing.Size(133, 52);
            this.btnOther.TabIndex = 348;
            this.btnOther.Text = "Other";
            this.btnOther.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpForm);
            this.panel1.Controls.Add(this.grbCheque);
            this.panel1.Location = new System.Drawing.Point(154, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 331);
            this.panel1.TabIndex = 348;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIRM PAYMENT";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grpForm.ResumeLayout(false);
            this.grpBalance.ResumeLayout(false);
            this.grpBalance.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbCheque.ResumeLayout(false);
            this.pnlChequeInfo.ResumeLayout(false);
            this.pnlChequeInfo.PerformLayout();
            this.grpChequeSupplier.ResumeLayout(false);
            this.grpChequeSupplier.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.GroupBox grbCheque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtBank;
        private Guna.UI2.WinForms.Guna2TextBox txtChequeNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheque;
        private Guna.UI2.WinForms.Guna2ComboBox cmbChequeType;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.GroupBox grpBalance;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtOtherPayment;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAccount;
        private Guna.UI2.WinForms.Guna2Chip chipAccountBalance;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private Guna.UI2.WinForms.Guna2Button btnCheque;
        private Guna.UI2.WinForms.Guna2Chip chipPayment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnOther;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch togglePartyCheque;
        private System.Windows.Forms.GroupBox grpChequeSupplier;
        private System.Windows.Forms.Panel pnlChequeInfo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnPartyCheque;
    }
}