namespace POS_System
{
    partial class frmStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockForm));
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnAddUnit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddBrand = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddCategory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cmbUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAlertQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleIsFeatured = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.dgvContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaDarg = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.grpMoreDetails = new System.Windows.Forms.GroupBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpManufacture = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpExpiry = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkDate = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUnitSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chipQuantity = new Guna.UI2.WinForms.Guna2Chip();
            this.label9 = new System.Windows.Forms.Label();
            this.grpForm.SuspendLayout();
            this.dgvContext.SuspendLayout();
            this.grpMoreDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnAddUnit);
            this.grpForm.Controls.Add(this.btnAddBrand);
            this.grpForm.Controls.Add(this.btnAddCategory);
            this.grpForm.Controls.Add(this.cmbUnit);
            this.grpForm.Controls.Add(this.cmbBrand);
            this.grpForm.Controls.Add(this.cmbCategory);
            this.grpForm.Controls.Add(this.txtAlertQuantity);
            this.grpForm.Controls.Add(this.txtDescription);
            this.grpForm.Controls.Add(this.txtItemName);
            this.grpForm.Controls.Add(this.txtItemCode);
            this.grpForm.Controls.Add(this.label11);
            this.grpForm.Controls.Add(this.label5);
            this.grpForm.Controls.Add(this.label1);
            this.grpForm.Controls.Add(this.label4);
            this.grpForm.Controls.Add(this.label2);
            this.grpForm.Controls.Add(this.label6);
            this.grpForm.Controls.Add(this.label3);
            this.grpForm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpForm.Location = new System.Drawing.Point(15, 70);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(718, 297);
            this.grpForm.TabIndex = 8;
            this.grpForm.TabStop = false;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Animated = true;
            this.btnAddUnit.CheckedState.Parent = this.btnAddUnit;
            this.btnAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUnit.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddUnit.CustomImages.Parent = this.btnAddUnit;
            this.btnAddUnit.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUnit.ForeColor = System.Drawing.Color.White;
            this.btnAddUnit.HoverState.Parent = this.btnAddUnit;
            this.btnAddUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnit.Image")));
            this.btnAddUnit.Location = new System.Drawing.Point(324, 247);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddUnit.ShadowDecoration.Parent = this.btnAddUnit;
            this.btnAddUnit.Size = new System.Drawing.Size(30, 30);
            this.btnAddUnit.TabIndex = 349;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Animated = true;
            this.btnAddBrand.CheckedState.Parent = this.btnAddBrand;
            this.btnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBrand.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddBrand.CustomImages.Parent = this.btnAddBrand;
            this.btnAddBrand.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.HoverState.Parent = this.btnAddBrand;
            this.btnAddBrand.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBrand.Image")));
            this.btnAddBrand.Location = new System.Drawing.Point(663, 184);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddBrand.ShadowDecoration.Parent = this.btnAddBrand;
            this.btnAddBrand.Size = new System.Drawing.Size(30, 30);
            this.btnAddBrand.TabIndex = 7;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Animated = true;
            this.btnAddCategory.CheckedState.Parent = this.btnAddCategory;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCategory.CustomImages.Parent = this.btnAddCategory;
            this.btnAddCategory.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.HoverState.Parent = this.btnAddCategory;
            this.btnAddCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(324, 184);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCategory.ShadowDecoration.Parent = this.btnAddCategory;
            this.btnAddCategory.Size = new System.Drawing.Size(30, 30);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.Animated = true;
            this.cmbUnit.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbUnit.BorderRadius = 5;
            this.cmbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUnit.FocusedState.Parent = this.cmbUnit;
            this.cmbUnit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.HoverState.Parent = this.cmbUnit;
            this.cmbUnit.ItemHeight = 30;
            this.cmbUnit.Items.AddRange(new object[] {
            "KG",
            "PCS"});
            this.cmbUnit.ItemsAppearance.Parent = this.cmbUnit;
            this.cmbUnit.Location = new System.Drawing.Point(107, 242);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.ShadowDecoration.Parent = this.cmbUnit;
            this.cmbUnit.Size = new System.Drawing.Size(212, 36);
            this.cmbUnit.TabIndex = 8;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Animated = true;
            this.cmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmbBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbBrand.BorderRadius = 5;
            this.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBrand.FocusedState.Parent = this.cmbBrand;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.HoverState.Parent = this.cmbBrand;
            this.cmbBrand.ItemHeight = 30;
            this.cmbBrand.ItemsAppearance.Parent = this.cmbBrand;
            this.cmbBrand.Location = new System.Drawing.Point(451, 181);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.ShadowDecoration.Parent = this.cmbBrand;
            this.cmbBrand.Size = new System.Drawing.Size(206, 36);
            this.cmbBrand.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Animated = true;
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbCategory.BorderRadius = 5;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(107, 181);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(212, 36);
            this.cmbCategory.TabIndex = 4;
            // 
            // txtAlertQuantity
            // 
            this.txtAlertQuantity.Animated = true;
            this.txtAlertQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtAlertQuantity.BorderRadius = 5;
            this.txtAlertQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlertQuantity.DefaultText = "";
            this.txtAlertQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlertQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlertQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlertQuantity.DisabledState.Parent = this.txtAlertQuantity;
            this.txtAlertQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlertQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlertQuantity.FocusedState.Parent = this.txtAlertQuantity;
            this.txtAlertQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAlertQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlertQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlertQuantity.HoverState.Parent = this.txtAlertQuantity;
            this.txtAlertQuantity.Location = new System.Drawing.Point(453, 242);
            this.txtAlertQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlertQuantity.Name = "txtAlertQuantity";
            this.txtAlertQuantity.PasswordChar = '\0';
            this.txtAlertQuantity.PlaceholderText = "Alert Quantity";
            this.txtAlertQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlertQuantity.SelectedText = "";
            this.txtAlertQuantity.ShadowDecoration.Parent = this.txtAlertQuantity;
            this.txtAlertQuantity.Size = new System.Drawing.Size(239, 35);
            this.txtAlertQuantity.TabIndex = 9;
            this.txtAlertQuantity.Tag = "Alert Quantity Required";
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
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(105, 124);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "Item Description";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(588, 35);
            this.txtDescription.TabIndex = 3;
            // 
            // txtItemName
            // 
            this.txtItemName.Animated = true;
            this.txtItemName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtItemName.BorderRadius = 5;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(105, 71);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "Item Name";
            this.txtItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(588, 35);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.Tag = "Item Name Required";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Animated = true;
            this.txtItemCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtItemCode.BorderRadius = 5;
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.DefaultText = "";
            this.txtItemCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.DisabledState.Parent = this.txtItemCode;
            this.txtItemCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.FocusedState.Parent = this.txtItemCode;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtItemCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.HoverState.Parent = this.txtItemCode;
            this.txtItemCode.Location = new System.Drawing.Point(105, 24);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PlaceholderText = "Your Custom Code No";
            this.txtItemCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.ShadowDecoration.Parent = this.txtItemCode;
            this.txtItemCode.Size = new System.Drawing.Size(588, 35);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.Tag = "Item Code Required";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Unit Type";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brand";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alert Qty.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleIsFeatured
            // 
            this.toggleIsFeatured.Animated = true;
            this.toggleIsFeatured.AutoRoundedCorners = true;
            this.toggleIsFeatured.Checked = true;
            this.toggleIsFeatured.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleIsFeatured.CheckedState.BorderRadius = 16;
            this.toggleIsFeatured.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleIsFeatured.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleIsFeatured.CheckedState.InnerBorderRadius = 12;
            this.toggleIsFeatured.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleIsFeatured.CheckedState.Parent = this.toggleIsFeatured;
            this.toggleIsFeatured.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleIsFeatured.Location = new System.Drawing.Point(420, 558);
            this.toggleIsFeatured.Name = "toggleIsFeatured";
            this.toggleIsFeatured.ShadowDecoration.Parent = this.toggleIsFeatured;
            this.toggleIsFeatured.Size = new System.Drawing.Size(63, 34);
            this.toggleIsFeatured.TabIndex = 348;
            this.toggleIsFeatured.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleIsFeatured.UncheckedState.BorderRadius = 16;
            this.toggleIsFeatured.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleIsFeatured.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleIsFeatured.UncheckedState.InnerBorderRadius = 12;
            this.toggleIsFeatured.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleIsFeatured.UncheckedState.Parent = this.toggleIsFeatured;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(141, 564);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(273, 22);
            this.label13.TabIndex = 347;
            this.label13.Text = "Set Featured Item in POS Terminal?";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnSave.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(488, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(242, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 0);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(753, 54);
            this.guna2Chip1.TabIndex = 9;
            this.guna2Chip1.Text = "ADD / EDIT ITEMS";
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
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(703, 7);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.TabIndex = 10;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // dgvContext
            // 
            this.dgvContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.dgvContext.Name = "dgvContext";
            this.dgvContext.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // gunaDarg
            // 
            this.gunaDarg.TargetControl = this.guna2Chip1;
            // 
            // grpMoreDetails
            // 
            this.grpMoreDetails.Controls.Add(this.guna2Separator1);
            this.grpMoreDetails.Controls.Add(this.txtQuantity);
            this.grpMoreDetails.Controls.Add(this.label7);
            this.grpMoreDetails.Controls.Add(this.txtCost);
            this.grpMoreDetails.Controls.Add(this.label15);
            this.grpMoreDetails.Controls.Add(this.dtpManufacture);
            this.grpMoreDetails.Controls.Add(this.dtpExpiry);
            this.grpMoreDetails.Controls.Add(this.checkDate);
            this.grpMoreDetails.Controls.Add(this.label14);
            this.grpMoreDetails.Controls.Add(this.label16);
            this.grpMoreDetails.Controls.Add(this.txtUnitSalePrice);
            this.grpMoreDetails.Controls.Add(this.label8);
            this.grpMoreDetails.Location = new System.Drawing.Point(12, 368);
            this.grpMoreDetails.Name = "grpMoreDetails";
            this.grpMoreDetails.Size = new System.Drawing.Size(718, 172);
            this.grpMoreDetails.TabIndex = 349;
            this.grpMoreDetails.TabStop = false;
            this.grpMoreDetails.Enter += new System.EventHandler(this.grpMoreDetails_Enter);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(6, 77);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(706, 10);
            this.guna2Separator1.TabIndex = 361;
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
            this.txtQuantity.Location = new System.Drawing.Point(26, 125);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 1;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(190, 35);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Tag = "Quantity Required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 360;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCost
            // 
            this.txtCost.Animated = true;
            this.txtCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtCost.BorderRadius = 5;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.DefaultText = "0";
            this.txtCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.DisabledState.Parent = this.txtCost;
            this.txtCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.FocusedState.Parent = this.txtCost;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCost.HoverState.Parent = this.txtCost;
            this.txtCost.Location = new System.Drawing.Point(275, 125);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.PlaceholderText = "Cost";
            this.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCost.SelectedText = "";
            this.txtCost.SelectionStart = 1;
            this.txtCost.ShadowDecoration.Parent = this.txtCost;
            this.txtCost.Size = new System.Drawing.Size(190, 35);
            this.txtCost.TabIndex = 1;
            this.txtCost.Tag = "Cost of Item required";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(277, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 18);
            this.label15.TabIndex = 360;
            this.label15.Text = "Cost";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpManufacture
            // 
            this.dtpManufacture.BorderRadius = 8;
            this.dtpManufacture.CheckedState.Parent = this.dtpManufacture;
            this.dtpManufacture.Enabled = false;
            this.dtpManufacture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpManufacture.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpManufacture.ForeColor = System.Drawing.Color.White;
            this.dtpManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacture.HoverState.Parent = this.dtpManufacture;
            this.dtpManufacture.Location = new System.Drawing.Point(154, 27);
            this.dtpManufacture.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpManufacture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpManufacture.Name = "dtpManufacture";
            this.dtpManufacture.ShadowDecoration.Parent = this.dtpManufacture;
            this.dtpManufacture.Size = new System.Drawing.Size(155, 35);
            this.dtpManufacture.TabIndex = 354;
            this.dtpManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpManufacture.Value = new System.DateTime(2020, 7, 20, 13, 28, 41, 293);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.BorderRadius = 8;
            this.dtpExpiry.CheckedState.Parent = this.dtpExpiry;
            this.dtpExpiry.Enabled = false;
            this.dtpExpiry.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.dtpExpiry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpExpiry.ForeColor = System.Drawing.Color.White;
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.HoverState.Parent = this.dtpExpiry;
            this.dtpExpiry.Location = new System.Drawing.Point(471, 27);
            this.dtpExpiry.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpExpiry.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.ShadowDecoration.Parent = this.dtpExpiry;
            this.dtpExpiry.Size = new System.Drawing.Size(150, 35);
            this.dtpExpiry.TabIndex = 355;
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
            this.checkDate.Location = new System.Drawing.Point(630, 28);
            this.checkDate.Name = "checkDate";
            this.checkDate.ShadowDecoration.Parent = this.checkDate;
            this.checkDate.Size = new System.Drawing.Size(40, 35);
            this.checkDate.TabIndex = 356;
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
            this.label14.Location = new System.Drawing.Point(23, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 352;
            this.label14.Text = "Manufactured Date";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(378, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 353;
            this.label16.Text = "Expire Date";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitSalePrice
            // 
            this.txtUnitSalePrice.Animated = true;
            this.txtUnitSalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtUnitSalePrice.BorderRadius = 5;
            this.txtUnitSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitSalePrice.DefaultText = "0";
            this.txtUnitSalePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnitSalePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnitSalePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitSalePrice.DisabledState.Parent = this.txtUnitSalePrice;
            this.txtUnitSalePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnitSalePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitSalePrice.FocusedState.Parent = this.txtUnitSalePrice;
            this.txtUnitSalePrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUnitSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnitSalePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnitSalePrice.HoverState.Parent = this.txtUnitSalePrice;
            this.txtUnitSalePrice.Location = new System.Drawing.Point(511, 124);
            this.txtUnitSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitSalePrice.Name = "txtUnitSalePrice";
            this.txtUnitSalePrice.PasswordChar = '\0';
            this.txtUnitSalePrice.PlaceholderText = "Unit Sale Price";
            this.txtUnitSalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnitSalePrice.SelectedText = "";
            this.txtUnitSalePrice.SelectionStart = 1;
            this.txtUnitSalePrice.ShadowDecoration.Parent = this.txtUnitSalePrice;
            this.txtUnitSalePrice.Size = new System.Drawing.Size(184, 36);
            this.txtUnitSalePrice.TabIndex = 2;
            this.txtUnitSalePrice.Tag = "Price is Required";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(511, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Unit  Sale Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chipQuantity
            // 
            this.chipQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.chipQuantity.BorderRadius = 10;
            this.chipQuantity.FillColor = System.Drawing.Color.White;
            this.chipQuantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.chipQuantity.ForeColor = System.Drawing.Color.Black;
            this.chipQuantity.Location = new System.Drawing.Point(82, 6);
            this.chipQuantity.Name = "chipQuantity";
            this.chipQuantity.ShadowDecoration.Parent = this.chipQuantity;
            this.chipQuantity.Size = new System.Drawing.Size(119, 42);
            this.chipQuantity.TabIndex = 350;
            this.chipQuantity.Text = "0";
            this.chipQuantity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 40);
            this.label9.TabIndex = 3;
            this.label9.Text = "On hand \r\nQty.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 619);
            this.ControlBox = false;
            this.Controls.Add(this.chipQuantity);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.toggleIsFeatured);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.grpMoreDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ITEM DETAILS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmStockForm_Load);
            this.Shown += new System.EventHandler(this.frmStockForm_Shown);
            this.LocationChanged += new System.EventHandler(this.frmStockForm_LocationChanged);
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            this.dgvContext.ResumeLayout(false);
            this.grpMoreDetails.ResumeLayout(false);
            this.grpMoreDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBrand;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtAlertQuantity;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleIsFeatured;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCategory;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddUnit;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddBrand;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.ContextMenuStrip dgvContext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Guna.UI2.WinForms.Guna2DragControl gunaDarg;
        private System.Windows.Forms.GroupBox grpMoreDetails;
        private Guna.UI2.WinForms.Guna2TextBox txtUnitSalePrice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Chip chipQuantity;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpManufacture;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpExpiry;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtCost;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
    }
}