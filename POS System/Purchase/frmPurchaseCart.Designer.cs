namespace POS_System
{
    partial class frmPurchaseCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseCart));
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chipProfit = new Guna.UI2.WinForms.Guna2Chip();
            this.dtpManufacture = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkDate = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chipLineAmount = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(443, 7);
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
            this.guna2Chip1.Size = new System.Drawing.Size(487, 49);
            this.guna2Chip1.TabIndex = 19;
            this.guna2Chip1.Text = "Purchase";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Chip1;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Animated = true;
            this.txtSalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtSalePrice.BorderRadius = 5;
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.DefaultText = "0";
            this.txtSalePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.DisabledState.Parent = this.txtSalePrice;
            this.txtSalePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.FocusedState.Parent = this.txtSalePrice;
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.HoverState.Parent = this.txtSalePrice;
            this.txtSalePrice.Location = new System.Drawing.Point(115, 117);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.PlaceholderText = "Sale Price";
            this.txtSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.SelectionStart = 1;
            this.txtSalePrice.ShadowDecoration.Parent = this.txtSalePrice;
            this.txtSalePrice.Size = new System.Drawing.Size(134, 35);
            this.txtSalePrice.TabIndex = 2;
            this.txtSalePrice.Tag = "Price is Required";
            this.txtSalePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderRadius = 5;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "0";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(115, 169);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 1;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(134, 35);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Tag = "Quantity Required";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sale Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemCost
            // 
            this.txtItemCost.Animated = true;
            this.txtItemCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtItemCost.BorderRadius = 5;
            this.txtItemCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCost.DefaultText = "0";
            this.txtItemCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCost.DisabledState.Parent = this.txtItemCost;
            this.txtItemCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCost.FocusedState.Parent = this.txtItemCost;
            this.txtItemCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItemCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCost.HoverState.Parent = this.txtItemCost;
            this.txtItemCost.Location = new System.Drawing.Point(338, 117);
            this.txtItemCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.PasswordChar = '\0';
            this.txtItemCost.PlaceholderText = "Item Cost";
            this.txtItemCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItemCost.SelectedText = "";
            this.txtItemCost.SelectionStart = 1;
            this.txtItemCost.ShadowDecoration.Parent = this.txtItemCost;
            this.txtItemCost.Size = new System.Drawing.Size(138, 35);
            this.txtItemCost.TabIndex = 3;
            this.txtItemCost.Tag = "Cost of Item required";
            this.txtItemCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(270, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 18);
            this.label17.TabIndex = 25;
            this.label17.Text = "Item Cost";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Animated = true;
            this.txtPurchasePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.BorderRadius = 5;
            this.txtPurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPurchasePrice.DefaultText = "0";
            this.txtPurchasePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPurchasePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPurchasePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.DisabledState.Parent = this.txtPurchasePrice;
            this.txtPurchasePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPurchasePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.FocusedState.Parent = this.txtPurchasePrice;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPurchasePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPurchasePrice.HoverState.Parent = this.txtPurchasePrice;
            this.txtPurchasePrice.Location = new System.Drawing.Point(115, 64);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PasswordChar = '\0';
            this.txtPurchasePrice.PlaceholderText = "Purchase Price";
            this.txtPurchasePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.SelectionStart = 1;
            this.txtPurchasePrice.ShadowDecoration.Parent = this.txtPurchasePrice;
            this.txtPurchasePrice.Size = new System.Drawing.Size(134, 35);
            this.txtPurchasePrice.TabIndex = 0;
            this.txtPurchasePrice.Tag = "Cost of Item required";
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Purchase Price";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Quantity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estd. Profit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chipProfit
            // 
            this.chipProfit.BorderRadius = 5;
            this.chipProfit.FillColor = System.Drawing.Color.SeaGreen;
            this.chipProfit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chipProfit.ForeColor = System.Drawing.Color.White;
            this.chipProfit.Location = new System.Drawing.Point(338, 169);
            this.chipProfit.Name = "chipProfit";
            this.chipProfit.ShadowDecoration.Parent = this.chipProfit;
            this.chipProfit.Size = new System.Drawing.Size(138, 35);
            this.chipProfit.TabIndex = 352;
            this.chipProfit.TabStop = false;
            this.chipProfit.Text = "0";
            this.chipProfit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dtpManufacture
            // 
            this.dtpManufacture.BorderRadius = 5;
            this.dtpManufacture.CheckedState.Parent = this.dtpManufacture;
            this.dtpManufacture.Enabled = false;
            this.dtpManufacture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpManufacture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpManufacture.ForeColor = System.Drawing.Color.White;
            this.dtpManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacture.HoverState.Parent = this.dtpManufacture;
            this.dtpManufacture.Location = new System.Drawing.Point(19, 296);
            this.dtpManufacture.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpManufacture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpManufacture.Name = "dtpManufacture";
            this.dtpManufacture.ShadowDecoration.Parent = this.dtpManufacture;
            this.dtpManufacture.Size = new System.Drawing.Size(132, 35);
            this.dtpManufacture.TabIndex = 5;
            this.dtpManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpManufacture.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.BorderRadius = 5;
            this.dtpExpiry.CheckedState.Parent = this.dtpExpiry;
            this.dtpExpiry.Enabled = false;
            this.dtpExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpExpiry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpExpiry.ForeColor = System.Drawing.Color.White;
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.HoverState.Parent = this.dtpExpiry;
            this.dtpExpiry.Location = new System.Drawing.Point(171, 296);
            this.dtpExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.ShadowDecoration.Parent = this.dtpExpiry;
            this.dtpExpiry.Size = new System.Drawing.Size(132, 35);
            this.dtpExpiry.TabIndex = 6;
            this.dtpExpiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpExpiry.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // checkDate
            // 
            this.checkDate.Animated = true;
            this.checkDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkDate.CheckedState.BorderRadius = 2;
            this.checkDate.CheckedState.BorderThickness = 0;
            this.checkDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkDate.CheckedState.Parent = this.checkDate;
            this.checkDate.Location = new System.Drawing.Point(310, 301);
            this.checkDate.Name = "checkDate";
            this.checkDate.ShadowDecoration.Parent = this.checkDate;
            this.checkDate.Size = new System.Drawing.Size(24, 25);
            this.checkDate.TabIndex = 7;
            this.checkDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkDate.UncheckedState.BorderRadius = 2;
            this.checkDate.UncheckedState.BorderThickness = 0;
            this.checkDate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkDate.UncheckedState.Parent = this.checkDate;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 354;
            this.label14.Text = "Manufactured Date";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(168, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 355;
            this.label16.Text = "Expire Date";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(350, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(126, 65);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Line Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chipLineAmount
            // 
            this.chipLineAmount.BorderRadius = 5;
            this.chipLineAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.chipLineAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chipLineAmount.ForeColor = System.Drawing.Color.White;
            this.chipLineAmount.Location = new System.Drawing.Point(115, 217);
            this.chipLineAmount.Name = "chipLineAmount";
            this.chipLineAmount.ShadowDecoration.Parent = this.chipLineAmount;
            this.chipLineAmount.Size = new System.Drawing.Size(360, 35);
            this.chipLineAmount.TabIndex = 352;
            this.chipLineAmount.TabStop = false;
            this.chipLineAmount.Text = "0";
            this.chipLineAmount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 256);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(487, 10);
            this.guna2Separator1.TabIndex = 362;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Animated = true;
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtDiscount.BorderRadius = 5;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(338, 64);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "Discount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 1;
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(138, 35);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.Tag = "Price is Required";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);
            // 
            // frmPurchaseCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 351);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpManufacture);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chipLineAmount);
            this.Controls.Add(this.chipProfit);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseCart";
            this.Text = "frmPurchaseCart";
            this.Shown += new System.EventHandler(this.frmPurchaseCart_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtSalePrice;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCost;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Chip chipProfit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpManufacture;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiry;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Chip chipLineAmount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label4;
    }
}