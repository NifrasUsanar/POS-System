namespace POS_System
{
    partial class ucPurchaseOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPurchaseOrder));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageForm = new System.Windows.Forms.TabPage();
            this.dgvOrderProduct = new System.Windows.Forms.DataGridView();
            this.pageOrder = new System.Windows.Forms.TabPage();
            this.btnOrderForm = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.btnComplete = new Guna.UI2.WinForms.Guna2Button();
            this.cellItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellAdd = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cmbUnit = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cellCartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellCartQty = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellCartRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtSupplierSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbOrderStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cellOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellStatus = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellOrderPrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellOrderRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabControl.SuspendLayout();
            this.pageForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).BeginInit();
            this.pageOrder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.ColumnHeadersHeight = 35;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellOrderID,
            this.cellSupplierID,
            this.cellSupplier,
            this.cellStatus,
            this.Column2,
            this.cellOrderPrint,
            this.cellEdit,
            this.cellOrderRemove});
            this.dgvOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.NullValue = "...";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.EnableHeadersVisualStyles = false;
            this.dgvOrder.GridColor = System.Drawing.Color.White;
            this.dgvOrder.Location = new System.Drawing.Point(6, 57);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrder.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrder.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrder.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.RowTemplate.DividerHeight = 1;
            this.dgvOrder.RowTemplate.Height = 30;
            this.dgvOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.ShowCellToolTips = false;
            this.dgvOrder.Size = new System.Drawing.Size(1016, 253);
            this.dgvOrder.TabIndex = 310;
            this.dgvOrder.TabStop = false;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pageForm);
            this.tabControl.Controls.Add(this.pageOrder);
            this.tabControl.Location = new System.Drawing.Point(6, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1033, 342);
            this.tabControl.TabIndex = 311;
            // 
            // pageForm
            // 
            this.pageForm.Controls.Add(this.panel1);
            this.pageForm.Controls.Add(this.panel2);
            this.pageForm.Location = new System.Drawing.Point(4, 22);
            this.pageForm.Name = "pageForm";
            this.pageForm.Padding = new System.Windows.Forms.Padding(3);
            this.pageForm.Size = new System.Drawing.Size(1025, 316);
            this.pageForm.TabIndex = 1;
            this.pageForm.Text = "Order Form";
            this.pageForm.UseVisualStyleBackColor = true;
            // 
            // dgvOrderProduct
            // 
            this.dgvOrderProduct.AllowUserToAddRows = false;
            this.dgvOrderProduct.AllowUserToDeleteRows = false;
            this.dgvOrderProduct.AllowUserToResizeColumns = false;
            this.dgvOrderProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrderProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrderProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderProduct.ColumnHeadersHeight = 35;
            this.dgvOrderProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellItemID,
            this.Column4,
            this.Column3,
            this.Column5,
            this.cellAdd});
            this.dgvOrderProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.NullValue = "...";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProduct.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderProduct.EnableHeadersVisualStyles = false;
            this.dgvOrderProduct.GridColor = System.Drawing.Color.White;
            this.dgvOrderProduct.Location = new System.Drawing.Point(3, 50);
            this.dgvOrderProduct.MultiSelect = false;
            this.dgvOrderProduct.Name = "dgvOrderProduct";
            this.dgvOrderProduct.ReadOnly = true;
            this.dgvOrderProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderProduct.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderProduct.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrderProduct.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProduct.RowTemplate.DividerHeight = 1;
            this.dgvOrderProduct.RowTemplate.Height = 30;
            this.dgvOrderProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderProduct.ShowCellToolTips = false;
            this.dgvOrderProduct.Size = new System.Drawing.Size(473, 255);
            this.dgvOrderProduct.TabIndex = 311;
            this.dgvOrderProduct.TabStop = false;
            this.dgvOrderProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderProduct_CellContentClick);
            // 
            // pageOrder
            // 
            this.pageOrder.Controls.Add(this.txtSupplierSearch);
            this.pageOrder.Controls.Add(this.cmbOrderStatus);
            this.pageOrder.Controls.Add(this.dgvOrder);
            this.pageOrder.Location = new System.Drawing.Point(4, 22);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.pageOrder.Size = new System.Drawing.Size(1025, 316);
            this.pageOrder.TabIndex = 0;
            this.pageOrder.Text = "Order";
            this.pageOrder.UseVisualStyleBackColor = true;
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Animated = true;
            this.btnOrderForm.BorderRadius = 6;
            this.btnOrderForm.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrderForm.Checked = true;
            this.btnOrderForm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnOrderForm.CheckedState.Parent = this.btnOrderForm;
            this.btnOrderForm.CustomBorderColor = System.Drawing.Color.White;
            this.btnOrderForm.CustomImages.Parent = this.btnOrderForm;
            this.btnOrderForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrderForm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnOrderForm.ForeColor = System.Drawing.Color.White;
            this.btnOrderForm.HoverState.Parent = this.btnOrderForm;
            this.btnOrderForm.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOrderForm.Location = new System.Drawing.Point(10, 11);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.ShadowDecoration.Parent = this.btnOrderForm;
            this.btnOrderForm.Size = new System.Drawing.Size(193, 42);
            this.btnOrderForm.TabIndex = 374;
            this.btnOrderForm.Text = "Create Order";
            this.btnOrderForm.TextOffset = new System.Drawing.Point(3, 0);
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Animated = true;
            this.btnViewOrder.BorderRadius = 6;
            this.btnViewOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnViewOrder.CheckedState.Parent = this.btnViewOrder;
            this.btnViewOrder.CustomBorderColor = System.Drawing.Color.White;
            this.btnViewOrder.CustomImages.Parent = this.btnViewOrder;
            this.btnViewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewOrder.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewOrder.ForeColor = System.Drawing.Color.White;
            this.btnViewOrder.HoverState.Parent = this.btnViewOrder;
            this.btnViewOrder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewOrder.Location = new System.Drawing.Point(209, 11);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.ShadowDecoration.Parent = this.btnViewOrder;
            this.btnViewOrder.Size = new System.Drawing.Size(193, 42);
            this.btnViewOrder.TabIndex = 374;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.TextOffset = new System.Drawing.Point(3, 0);
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUnit);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.dgvOrderProduct);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 310);
            this.panel1.TabIndex = 312;
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.BorderRadius = 6;
            this.btnFilter.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomBorderColor = System.Drawing.Color.White;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFilter.Location = new System.Drawing.Point(291, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(82, 35);
            this.btnFilter.TabIndex = 374;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtQuantity.BorderRadius = 6;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "0";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(6, 8);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionStart = 1;
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(108, 34);
            this.txtQuantity.TabIndex = 375;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnComplete);
            this.panel2.Controls.Add(this.btnSupplier);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(485, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 310);
            this.panel2.TabIndex = 312;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeColumns = false;
            this.dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCart.ColumnHeadersHeight = 35;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellCartID,
            this.Column6,
            this.dataGridViewTextBoxColumn4,
            this.cellCartQty,
            this.cellCartRemove});
            this.dgvCart.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle11.NullValue = "...";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.White;
            this.dgvCart.Location = new System.Drawing.Point(6, 50);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.RowHeadersVisible = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCart.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCart.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowTemplate.DividerHeight = 1;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.ShowCellToolTips = false;
            this.dgvCart.Size = new System.Drawing.Size(525, 258);
            this.dgvCart.TabIndex = 311;
            this.dgvCart.TabStop = false;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupplier.Animated = true;
            this.btnSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.BorderRadius = 5;
            this.btnSupplier.BorderThickness = 1;
            this.btnSupplier.CheckedState.Parent = this.btnSupplier;
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.CustomImages.Parent = this.btnSupplier;
            this.btnSupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.HoverState.Parent = this.btnSupplier;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSupplier.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSupplier.Location = new System.Drawing.Point(6, 9);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.ShadowDecoration.Parent = this.btnSupplier;
            this.btnSupplier.Size = new System.Drawing.Size(284, 37);
            this.btnSupplier.TabIndex = 312;
            this.btnSupplier.Tag = "0";
            this.btnSupplier.Text = "select your supplier";
            this.btnSupplier.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Animated = true;
            this.btnComplete.BorderRadius = 6;
            this.btnComplete.CheckedState.Parent = this.btnComplete;
            this.btnComplete.CustomImages.Parent = this.btnComplete;
            this.btnComplete.FillColor = System.Drawing.Color.SeaGreen;
            this.btnComplete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.HoverState.Parent = this.btnComplete;
            this.btnComplete.ImageSize = new System.Drawing.Size(18, 18);
            this.btnComplete.Location = new System.Drawing.Point(292, 9);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.ShadowDecoration.Parent = this.btnComplete;
            this.btnComplete.Size = new System.Drawing.Size(239, 37);
            this.btnComplete.TabIndex = 325;
            this.btnComplete.Text = "COMPLETE";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // cellItemID
            // 
            this.cellItemID.DataPropertyName = "item_id";
            this.cellItemID.FillWeight = 20F;
            this.cellItemID.HeaderText = "#";
            this.cellItemID.Name = "cellItemID";
            this.cellItemID.ReadOnly = true;
            this.cellItemID.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "itm_name";
            this.Column4.HeaderText = "Product";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "alert";
            this.Column3.HeaderText = "alert";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "quantity";
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cellAdd
            // 
            this.cellAdd.FillWeight = 20F;
            this.cellAdd.HeaderText = "ADD";
            this.cellAdd.Name = "cellAdd";
            this.cellAdd.ReadOnly = true;
            this.cellAdd.Text = "ADD";
            this.cellAdd.UseColumnTextForLinkValue = true;
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
            this.cmbUnit.ItemsAppearance.Parent = this.cmbUnit;
            this.cmbUnit.Location = new System.Drawing.Point(122, 8);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.ShadowDecoration.Parent = this.cmbUnit;
            this.cmbUnit.Size = new System.Drawing.Size(163, 36);
            this.cmbUnit.TabIndex = 376;
            // 
            // cellCartID
            // 
            this.cellCartID.DataPropertyName = "id";
            this.cellCartID.FillWeight = 20F;
            this.cellCartID.HeaderText = "#";
            this.cellCartID.Name = "cellCartID";
            this.cellCartID.ReadOnly = true;
            this.cellCartID.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "item_id";
            this.Column6.HeaderText = "Item ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itm_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cellCartQty
            // 
            this.cellCartQty.DataPropertyName = "qty";
            this.cellCartQty.FillWeight = 50F;
            this.cellCartQty.HeaderText = "Qty";
            this.cellCartQty.Name = "cellCartQty";
            this.cellCartQty.ReadOnly = true;
            this.cellCartQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellCartQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cellCartRemove
            // 
            this.cellCartRemove.FillWeight = 30F;
            this.cellCartRemove.HeaderText = "REMOVE";
            this.cellCartRemove.Name = "cellCartRemove";
            this.cellCartRemove.ReadOnly = true;
            this.cellCartRemove.Text = "REMOVE";
            this.cellCartRemove.UseColumnTextForLinkValue = true;
            // 
            // txtSupplierSearch
            // 
            this.txtSupplierSearch.Animated = true;
            this.txtSupplierSearch.AutoRoundedCorners = true;
            this.txtSupplierSearch.BackColor = System.Drawing.Color.White;
            this.txtSupplierSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtSupplierSearch.BorderRadius = 17;
            this.txtSupplierSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierSearch.DefaultText = "";
            this.txtSupplierSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupplierSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupplierSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierSearch.DisabledState.Parent = this.txtSupplierSearch;
            this.txtSupplierSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierSearch.FocusedState.Parent = this.txtSupplierSearch;
            this.txtSupplierSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSupplierSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupplierSearch.HoverState.Parent = this.txtSupplierSearch;
            this.txtSupplierSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSupplierSearch.IconLeft")));
            this.txtSupplierSearch.Location = new System.Drawing.Point(10, 12);
            this.txtSupplierSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplierSearch.Name = "txtSupplierSearch";
            this.txtSupplierSearch.PasswordChar = '\0';
            this.txtSupplierSearch.PlaceholderText = "Search Supplier";
            this.txtSupplierSearch.SelectedText = "";
            this.txtSupplierSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSupplierSearch.ShadowDecoration.Depth = 1;
            this.txtSupplierSearch.ShadowDecoration.Parent = this.txtSupplierSearch;
            this.txtSupplierSearch.Size = new System.Drawing.Size(281, 36);
            this.txtSupplierSearch.TabIndex = 333;
            this.txtSupplierSearch.TextChanged += new System.EventHandler(this.txtSupplierSearch_TextChanged);
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.Animated = true;
            this.cmbOrderStatus.AutoRoundedCorners = true;
            this.cmbOrderStatus.BackColor = System.Drawing.Color.White;
            this.cmbOrderStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbOrderStatus.BorderRadius = 17;
            this.cmbOrderStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbOrderStatus.FocusedState.Parent = this.cmbOrderStatus;
            this.cmbOrderStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbOrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.HoverState.Parent = this.cmbOrderStatus;
            this.cmbOrderStatus.ItemHeight = 30;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed"});
            this.cmbOrderStatus.ItemsAppearance.Parent = this.cmbOrderStatus;
            this.cmbOrderStatus.Location = new System.Drawing.Point(296, 12);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.ShadowDecoration.Parent = this.cmbOrderStatus;
            this.cmbOrderStatus.Size = new System.Drawing.Size(133, 36);
            this.cmbOrderStatus.StartIndex = 0;
            this.cmbOrderStatus.TabIndex = 335;
            this.cmbOrderStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbOrderStatus_SelectionChangeCommitted);
            // 
            // cellOrderID
            // 
            this.cellOrderID.DataPropertyName = "id";
            this.cellOrderID.FillWeight = 20F;
            this.cellOrderID.HeaderText = "#";
            this.cellOrderID.Name = "cellOrderID";
            this.cellOrderID.ReadOnly = true;
            this.cellOrderID.Visible = false;
            // 
            // cellSupplierID
            // 
            this.cellSupplierID.DataPropertyName = "supplier_id";
            this.cellSupplierID.HeaderText = "Supplier ID";
            this.cellSupplierID.Name = "cellSupplierID";
            this.cellSupplierID.ReadOnly = true;
            this.cellSupplierID.Visible = false;
            // 
            // cellSupplier
            // 
            this.cellSupplier.DataPropertyName = "name";
            this.cellSupplier.HeaderText = "Supplier";
            this.cellSupplier.Name = "cellSupplier";
            this.cellSupplier.ReadOnly = true;
            // 
            // cellStatus
            // 
            this.cellStatus.DataPropertyName = "status";
            this.cellStatus.FillWeight = 50F;
            this.cellStatus.HeaderText = "Status";
            this.cellStatus.Name = "cellStatus";
            this.cellStatus.ReadOnly = true;
            this.cellStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "created_at";
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Created At";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cellOrderPrint
            // 
            this.cellOrderPrint.FillWeight = 30F;
            this.cellOrderPrint.HeaderText = "Print";
            this.cellOrderPrint.Name = "cellOrderPrint";
            this.cellOrderPrint.ReadOnly = true;
            this.cellOrderPrint.Text = "Print";
            this.cellOrderPrint.UseColumnTextForLinkValue = true;
            // 
            // cellEdit
            // 
            this.cellEdit.FillWeight = 30F;
            this.cellEdit.HeaderText = "Edit";
            this.cellEdit.Name = "cellEdit";
            this.cellEdit.ReadOnly = true;
            this.cellEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellEdit.Text = "EDIT";
            this.cellEdit.UseColumnTextForLinkValue = true;
            // 
            // cellOrderRemove
            // 
            this.cellOrderRemove.FillWeight = 30F;
            this.cellOrderRemove.HeaderText = "Remove";
            this.cellOrderRemove.Name = "cellOrderRemove";
            this.cellOrderRemove.ReadOnly = true;
            this.cellOrderRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellOrderRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cellOrderRemove.Text = "Remove";
            this.cellOrderRemove.UseColumnTextForLinkValue = true;
            this.cellOrderRemove.Visible = false;
            // 
            // ucPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnOrderForm);
            this.Controls.Add(this.tabControl);
            this.Name = "ucPurchaseOrder";
            this.Size = new System.Drawing.Size(1042, 409);
            this.Load += new System.EventHandler(this.ucPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.pageForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProduct)).EndInit();
            this.pageOrder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageOrder;
        private System.Windows.Forms.TabPage pageForm;
        private Guna.UI2.WinForms.Guna2Button btnOrderForm;
        private Guna.UI2.WinForms.Guna2Button btnViewOrder;
        private System.Windows.Forms.DataGridView dgvOrderProduct;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCart;
        private Guna.UI2.WinForms.Guna2Button btnSupplier;
        private Guna.UI2.WinForms.Guna2Button btnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn cellAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellCartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn cellCartQty;
        private System.Windows.Forms.DataGridViewLinkColumn cellCartRemove;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellSupplier;
        private System.Windows.Forms.DataGridViewLinkColumn cellStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn cellOrderPrint;
        private System.Windows.Forms.DataGridViewLinkColumn cellEdit;
        private System.Windows.Forms.DataGridViewLinkColumn cellOrderRemove;
    }
}
