namespace POS_System
{
    partial class frmPeopleDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleDetail));
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblPeopleName = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBills = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewCheque = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaymentHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnMakePayment = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewPurchase = new Guna.UI2.WinForms.Guna2Button();
            this.txtRefrenceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditPeople = new Guna.UI2.WinForms.Guna2Button();
            this.grpPurchase = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.chipBalance = new Guna.UI2.WinForms.Guna2Chip();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpPurchase.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
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
            this.btnClose.Location = new System.Drawing.Point(124, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPeopleName
            // 
            this.lblPeopleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.lblPeopleName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPeopleName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleName.ForeColor = System.Drawing.Color.White;
            this.lblPeopleName.Location = new System.Drawing.Point(0, 24);
            this.lblPeopleName.Name = "lblPeopleName";
            this.lblPeopleName.Size = new System.Drawing.Size(282, 76);
            this.lblPeopleName.TabIndex = 19;
            this.lblPeopleName.Text = "People Name";
            this.lblPeopleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(282, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnBills
            // 
            this.btnBills.Animated = true;
            this.btnBills.BorderRadius = 10;
            this.btnBills.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBills.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBills.CheckedState.Parent = this.btnBills;
            this.btnBills.CustomBorderColor = System.Drawing.Color.White;
            this.btnBills.CustomImages.Parent = this.btnBills;
            this.btnBills.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.HoverState.Parent = this.btnBills;
            this.btnBills.Location = new System.Drawing.Point(3, 3);
            this.btnBills.Name = "btnBills";
            this.btnBills.ShadowDecoration.Parent = this.btnBills;
            this.btnBills.Size = new System.Drawing.Size(232, 46);
            this.btnBills.TabIndex = 346;
            this.btnBills.Text = "VIEW PURCHASE";
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnBills);
            this.flowLayoutPanel1.Controls.Add(this.btnItems);
            this.flowLayoutPanel1.Controls.Add(this.btnViewCheque);
            this.flowLayoutPanel1.Controls.Add(this.btnPaymentHistory);
            this.flowLayoutPanel1.Controls.Add(this.btnMakePayment);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 314);
            this.flowLayoutPanel1.TabIndex = 347;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnItems
            // 
            this.btnItems.Animated = true;
            this.btnItems.BorderRadius = 10;
            this.btnItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnItems.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnItems.CheckedState.Parent = this.btnItems;
            this.btnItems.CustomBorderColor = System.Drawing.Color.White;
            this.btnItems.CustomImages.Parent = this.btnItems;
            this.btnItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.HoverState.Parent = this.btnItems;
            this.btnItems.Location = new System.Drawing.Point(3, 55);
            this.btnItems.Name = "btnItems";
            this.btnItems.ShadowDecoration.Parent = this.btnItems;
            this.btnItems.Size = new System.Drawing.Size(232, 46);
            this.btnItems.TabIndex = 348;
            this.btnItems.Text = "PURCHASE ITEMS";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnViewCheque
            // 
            this.btnViewCheque.Animated = true;
            this.btnViewCheque.BorderRadius = 10;
            this.btnViewCheque.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewCheque.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnViewCheque.CheckedState.Parent = this.btnViewCheque;
            this.btnViewCheque.CustomBorderColor = System.Drawing.Color.White;
            this.btnViewCheque.CustomImages.Parent = this.btnViewCheque;
            this.btnViewCheque.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewCheque.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnViewCheque.ForeColor = System.Drawing.Color.White;
            this.btnViewCheque.HoverState.Parent = this.btnViewCheque;
            this.btnViewCheque.Location = new System.Drawing.Point(3, 107);
            this.btnViewCheque.Name = "btnViewCheque";
            this.btnViewCheque.ShadowDecoration.Parent = this.btnViewCheque;
            this.btnViewCheque.Size = new System.Drawing.Size(232, 46);
            this.btnViewCheque.TabIndex = 347;
            this.btnViewCheque.Text = "VIEW CHEQUE";
            this.btnViewCheque.Click += new System.EventHandler(this.btnViewCheque_Click);
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Animated = true;
            this.btnPaymentHistory.BorderRadius = 10;
            this.btnPaymentHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPaymentHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPaymentHistory.CheckedState.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.CustomBorderColor = System.Drawing.Color.White;
            this.btnPaymentHistory.CustomImages.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaymentHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.btnPaymentHistory.HoverState.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.Location = new System.Drawing.Point(3, 159);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.ShadowDecoration.Parent = this.btnPaymentHistory;
            this.btnPaymentHistory.Size = new System.Drawing.Size(232, 46);
            this.btnPaymentHistory.TabIndex = 350;
            this.btnPaymentHistory.Text = "PAYMENT HISTORY";
            this.btnPaymentHistory.Click += new System.EventHandler(this.btnPaymentHistory_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Animated = true;
            this.btnMakePayment.BorderRadius = 10;
            this.btnMakePayment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMakePayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMakePayment.CheckedState.Parent = this.btnMakePayment;
            this.btnMakePayment.CustomBorderColor = System.Drawing.Color.White;
            this.btnMakePayment.CustomImages.Parent = this.btnMakePayment;
            this.btnMakePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMakePayment.ForeColor = System.Drawing.Color.White;
            this.btnMakePayment.HoverState.Parent = this.btnMakePayment;
            this.btnMakePayment.Location = new System.Drawing.Point(3, 211);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.ShadowDecoration.Parent = this.btnMakePayment;
            this.btnMakePayment.Size = new System.Drawing.Size(232, 46);
            this.btnMakePayment.TabIndex = 349;
            this.btnMakePayment.Text = "MAKE PAYMENT";
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Purchase Refrence No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnViewPurchase
            // 
            this.btnViewPurchase.Animated = true;
            this.btnViewPurchase.BorderRadius = 10;
            this.btnViewPurchase.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnViewPurchase.CheckedState.Parent = this.btnViewPurchase;
            this.btnViewPurchase.CustomBorderColor = System.Drawing.Color.White;
            this.btnViewPurchase.CustomImages.Parent = this.btnViewPurchase;
            this.btnViewPurchase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnViewPurchase.ForeColor = System.Drawing.Color.White;
            this.btnViewPurchase.HoverState.Parent = this.btnViewPurchase;
            this.btnViewPurchase.Location = new System.Drawing.Point(159, 15);
            this.btnViewPurchase.Name = "btnViewPurchase";
            this.btnViewPurchase.ShadowDecoration.Parent = this.btnViewPurchase;
            this.btnViewPurchase.Size = new System.Drawing.Size(88, 65);
            this.btnViewPurchase.TabIndex = 346;
            this.btnViewPurchase.Text = "VIEW";
            this.btnViewPurchase.Click += new System.EventHandler(this.btnViewPurchase_Click);
            // 
            // txtRefrenceNo
            // 
            this.txtRefrenceNo.Animated = true;
            this.txtRefrenceNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.BorderRadius = 6;
            this.txtRefrenceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefrenceNo.DefaultText = "0";
            this.txtRefrenceNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRefrenceNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRefrenceNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefrenceNo.DisabledState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRefrenceNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.FocusedState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtRefrenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRefrenceNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRefrenceNo.HoverState.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Location = new System.Drawing.Point(8, 38);
            this.txtRefrenceNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtRefrenceNo.Name = "txtRefrenceNo";
            this.txtRefrenceNo.PasswordChar = '\0';
            this.txtRefrenceNo.PlaceholderText = "";
            this.txtRefrenceNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRefrenceNo.SelectedText = "";
            this.txtRefrenceNo.SelectionStart = 1;
            this.txtRefrenceNo.ShadowDecoration.Parent = this.txtRefrenceNo;
            this.txtRefrenceNo.Size = new System.Drawing.Size(143, 37);
            this.txtRefrenceNo.TabIndex = 348;
            // 
            // btnEditPeople
            // 
            this.btnEditPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnEditPeople.BorderRadius = 6;
            this.btnEditPeople.CheckedState.Parent = this.btnEditPeople;
            this.btnEditPeople.CustomBorderColor = System.Drawing.Color.White;
            this.btnEditPeople.CustomImages.Parent = this.btnEditPeople;
            this.btnEditPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPeople.ForeColor = System.Drawing.Color.White;
            this.btnEditPeople.HoverState.Parent = this.btnEditPeople;
            this.btnEditPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPeople.Image")));
            this.btnEditPeople.ImageSize = new System.Drawing.Size(16, 16);
            this.btnEditPeople.Location = new System.Drawing.Point(222, 3);
            this.btnEditPeople.Name = "btnEditPeople";
            this.btnEditPeople.ShadowDecoration.Parent = this.btnEditPeople;
            this.btnEditPeople.Size = new System.Drawing.Size(57, 30);
            this.btnEditPeople.TabIndex = 349;
            this.btnEditPeople.Text = "EDIT";
            this.btnEditPeople.Click += new System.EventHandler(this.btnEditpeople_Click);
            // 
            // grpPurchase
            // 
            this.grpPurchase.Controls.Add(this.btnViewPurchase);
            this.grpPurchase.Controls.Add(this.txtRefrenceNo);
            this.grpPurchase.Controls.Add(this.label1);
            this.grpPurchase.Location = new System.Drawing.Point(17, 498);
            this.grpPurchase.Name = "grpPurchase";
            this.grpPurchase.Size = new System.Drawing.Size(253, 86);
            this.grpPurchase.TabIndex = 350;
            this.grpPurchase.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.picRefresh);
            this.panel1.Controls.Add(this.btnEditPeople);
            this.panel1.Controls.Add(this.lblPeopleName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 100);
            this.panel1.TabIndex = 351;
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(10, 10);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(24, 27);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 350;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // chipBalance
            // 
            this.chipBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.chipBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.chipBalance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.chipBalance.ForeColor = System.Drawing.Color.White;
            this.chipBalance.Location = new System.Drawing.Point(0, 100);
            this.chipBalance.Name = "chipBalance";
            this.chipBalance.ShadowDecoration.Parent = this.chipBalance;
            this.chipBalance.Size = new System.Drawing.Size(282, 69);
            this.chipBalance.TabIndex = 374;
            this.chipBalance.TabStop = false;
            this.chipBalance.Text = "Rs. 0";
            this.chipBalance.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnReport
            // 
            this.btnReport.Animated = true;
            this.btnReport.BorderRadius = 10;
            this.btnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReport.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnReport.CheckedState.Parent = this.btnReport;
            this.btnReport.CustomBorderColor = System.Drawing.Color.White;
            this.btnReport.CustomImages.Parent = this.btnReport;
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverState.Parent = this.btnReport;
            this.btnReport.Location = new System.Drawing.Point(3, 263);
            this.btnReport.Name = "btnReport";
            this.btnReport.ShadowDecoration.Parent = this.btnReport;
            this.btnReport.Size = new System.Drawing.Size(232, 46);
            this.btnReport.TabIndex = 349;
            this.btnReport.Text = "REPORT";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmPeopleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 677);
            this.Controls.Add(this.chipBalance);
            this.Controls.Add(this.grpPurchase);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeopleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmPeopleDetail";
            this.Shown += new System.EventHandler(this.frmPeopleDetail_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grpPurchase.ResumeLayout(false);
            this.grpPurchase.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Label lblPeopleName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnBills;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnViewCheque;
        private Guna.UI2.WinForms.Guna2Button btnItems;
        private Guna.UI2.WinForms.Guna2Button btnMakePayment;
        private Guna.UI2.WinForms.Guna2Button btnPaymentHistory;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnViewPurchase;
        private Guna.UI2.WinForms.Guna2TextBox txtRefrenceNo;
        private Guna.UI2.WinForms.Guna2Button btnEditPeople;
        private System.Windows.Forms.GroupBox grpPurchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRefresh;
        private Guna.UI2.WinForms.Guna2Chip chipBalance;
        private Guna.UI2.WinForms.Guna2Button btnReport;
    }
}