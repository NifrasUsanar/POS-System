namespace POS_System
{
    partial class ucStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStock));
            this.pnlView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRecords = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnGo = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chipTotalProduct = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalValuation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcItemName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellQuantity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReportPrint = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnStockAlert = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnStockHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pnlView.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.panel1);
            this.pnlView.Controls.Add(this.lblTotalQty);
            this.pnlView.Controls.Add(this.label8);
            this.pnlView.Controls.Add(this.lblOnHand);
            this.pnlView.Controls.Add(this.lblTotalItems);
            this.pnlView.Controls.Add(this.label2);
            this.pnlView.Controls.Add(this.label6);
            this.pnlView.Controls.Add(this.chipTotalProduct);
            this.pnlView.Controls.Add(this.lblTotalVal);
            this.pnlView.Controls.Add(this.label3);
            this.pnlView.Controls.Add(this.label4);
            this.pnlView.Controls.Add(this.lblTotalValuation);
            this.pnlView.Controls.Add(this.label1);
            this.pnlView.Controls.Add(this.dgvStock);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1585, 501);
            this.pnlView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbRecords);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.lblResults);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Location = new System.Drawing.Point(6, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 66);
            this.panel1.TabIndex = 311;
            // 
            // cmbRecords
            // 
            this.cmbRecords.BackColor = System.Drawing.Color.Transparent;
            this.cmbRecords.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecords.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRecords.FocusedState.Parent = this.cmbRecords;
            this.cmbRecords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRecords.FormattingEnabled = true;
            this.cmbRecords.HoverState.Parent = this.cmbRecords;
            this.cmbRecords.ItemHeight = 25;
            this.cmbRecords.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200"});
            this.cmbRecords.ItemsAppearance.Parent = this.cmbRecords;
            this.cmbRecords.Location = new System.Drawing.Point(186, 19);
            this.cmbRecords.Name = "cmbRecords";
            this.cmbRecords.ShadowDecoration.Parent = this.cmbRecords;
            this.cmbRecords.Size = new System.Drawing.Size(96, 31);
            this.cmbRecords.TabIndex = 311;
            // 
            // btnGo
            // 
            this.btnGo.BorderRadius = 7;
            this.btnGo.CheckedState.Parent = this.btnGo;
            this.btnGo.CustomImages.Parent = this.btnGo;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.HoverState.Parent = this.btnGo;
            this.btnGo.Location = new System.Drawing.Point(288, 18);
            this.btnGo.Name = "btnGo";
            this.btnGo.ShadowDecoration.Parent = this.btnGo;
            this.btnGo.Size = new System.Drawing.Size(51, 33);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "GO";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.CheckedState.Parent = this.btnNextPage;
            this.btnNextPage.CustomImages.Parent = this.btnNextPage;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.HoverState.Parent = this.btnNextPage;
            this.btnNextPage.Location = new System.Drawing.Point(142, 18);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.ShadowDecoration.Parent = this.btnNextPage;
            this.btnNextPage.Size = new System.Drawing.Size(35, 33);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = ">";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.CustomImages.Parent = this.btnPrev;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Location = new System.Drawing.Point(9, 17);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(35, 35);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(346, 19);
            this.lblResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(194, 30);
            this.lblResults.TabIndex = 310;
            this.lblResults.Text = "Found results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(51, 22);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(84, 25);
            this.lblPage.TabIndex = 310;
            this.lblPage.Text = "Page";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.ForeColor = System.Drawing.Color.White;
            this.lblTotalQty.Location = new System.Drawing.Point(1430, 463);
            this.lblTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(146, 29);
            this.lblTotalQty.TabIndex = 310;
            this.lblTotalQty.Text = "0";
            this.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1306, 467);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 310;
            this.label8.Text = "On Hand Qty. :";
            // 
            // lblOnHand
            // 
            this.lblOnHand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnHand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnHand.ForeColor = System.Drawing.Color.White;
            this.lblOnHand.Location = new System.Drawing.Point(1430, 424);
            this.lblOnHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(146, 29);
            this.lblOnHand.TabIndex = 310;
            this.lblOnHand.Text = "0";
            this.lblOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(805, 463);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(134, 29);
            this.lblTotalItems.TabIndex = 310;
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1317, 428);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 310;
            this.label2.Text = "Current Qty. :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 467);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 310;
            this.label6.Text = "Total Item";
            // 
            // chipTotalProduct
            // 
            this.chipTotalProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chipTotalProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chipTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipTotalProduct.ForeColor = System.Drawing.Color.White;
            this.chipTotalProduct.Location = new System.Drawing.Point(805, 424);
            this.chipTotalProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chipTotalProduct.Name = "chipTotalProduct";
            this.chipTotalProduct.Size = new System.Drawing.Size(134, 29);
            this.chipTotalProduct.TabIndex = 310;
            this.chipTotalProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVal.ForeColor = System.Drawing.Color.White;
            this.lblTotalVal.Location = new System.Drawing.Point(1095, 463);
            this.lblTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(203, 29);
            this.lblTotalVal.TabIndex = 310;
            this.lblTotalVal.Text = "Rs. 0";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 310;
            this.label3.Text = "Current Items";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(962, 467);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 310;
            this.label4.Text = "Total Valuation :";
            // 
            // lblTotalValuation
            // 
            this.lblTotalValuation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValuation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalValuation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValuation.ForeColor = System.Drawing.Color.White;
            this.lblTotalValuation.Location = new System.Drawing.Point(1095, 424);
            this.lblTotalValuation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValuation.Name = "lblTotalValuation";
            this.lblTotalValuation.Size = new System.Drawing.Size(203, 29);
            this.lblTotalValuation.TabIndex = 310;
            this.lblTotalValuation.Text = "Rs. 0";
            this.lblTotalValuation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(944, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 310;
            this.label1.Text = "Current Valuation:";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvStock.ColumnHeadersHeight = 35;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.Column11,
            this.cellItemCode,
            this.dgcItemName,
            this.cellQuantity,
            this.Column8,
            this.Column1,
            this.Column9,
            this.Column6,
            this.cellLocation,
            this.Column7,
            this.Column3});
            this.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle20.NullValue = "...";
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.Color.White;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvStock.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvStock.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStock.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStock.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowTemplate.DividerHeight = 1;
            this.dgvStock.RowTemplate.Height = 30;
            this.dgvStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.ShowCellToolTips = false;
            this.dgvStock.Size = new System.Drawing.Size(1585, 417);
            this.dgvStock.TabIndex = 309;
            this.dgvStock.TabStop = false;
            this.dgvStock.VirtualMode = true;
            this.dgvStock.DataSourceChanged += new System.EventHandler(this.dgvStock_DataSourceChanged);
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // cellID
            // 
            this.cellID.DataPropertyName = "itm_id";
            this.cellID.FillWeight = 20F;
            this.cellID.HeaderText = "#";
            this.cellID.MinimumWidth = 6;
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            this.cellID.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "itm_barcode";
            this.Column11.HeaderText = "Barcode";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // cellItemCode
            // 
            this.cellItemCode.DataPropertyName = "itm_code";
            this.cellItemCode.FillWeight = 50F;
            this.cellItemCode.HeaderText = "Code No";
            this.cellItemCode.MinimumWidth = 6;
            this.cellItemCode.Name = "cellItemCode";
            this.cellItemCode.ReadOnly = true;
            // 
            // dgcItemName
            // 
            this.dgcItemName.DataPropertyName = "itm_name";
            this.dgcItemName.FillWeight = 126.8528F;
            this.dgcItemName.HeaderText = "Item Name";
            this.dgcItemName.MinimumWidth = 6;
            this.dgcItemName.Name = "dgcItemName";
            this.dgcItemName.ReadOnly = true;
            this.dgcItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcItemName.ToolTipText = "Edit or View";
            // 
            // cellQuantity
            // 
            this.cellQuantity.DataPropertyName = "quantity";
            this.cellQuantity.FillWeight = 67.65482F;
            this.cellQuantity.HeaderText = "Quantity";
            this.cellQuantity.MinimumWidth = 6;
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ReadOnly = true;
            this.cellQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "cost";
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column8.FillWeight = 67.65482F;
            this.Column8.HeaderText = "Cost";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "valuation";
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column1.FillWeight = 84.56853F;
            this.Column1.HeaderText = "Valuation";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "sale_price";
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column9.FillWeight = 67.65482F;
            this.Column9.HeaderText = "Sell Price";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "itm_alert";
            this.Column6.FillWeight = 50.74112F;
            this.Column6.HeaderText = "Alert";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cellLocation
            // 
            this.cellLocation.DataPropertyName = "name";
            this.cellLocation.HeaderText = "Location";
            this.cellLocation.MinimumWidth = 6;
            this.cellLocation.Name = "cellLocation";
            this.cellLocation.ReadOnly = true;
            this.cellLocation.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "brand_name";
            this.Column7.FillWeight = 84.56853F;
            this.Column7.HeaderText = "Brand";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "category_name";
            this.Column3.FillWeight = 84.56853F;
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnReportPrint);
            this.pnlTop.Controls.Add(this.btnStockAlert);
            this.pnlTop.Controls.Add(this.cmbBrand);
            this.pnlTop.Controls.Add(this.cmbCategory);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnFilter);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.btnStockHistory);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(7, 6);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlTop.Size = new System.Drawing.Size(1585, 70);
            this.pnlTop.TabIndex = 4;
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportPrint.Animated = true;
            this.btnReportPrint.BackColor = System.Drawing.Color.White;
            this.btnReportPrint.CheckedState.Parent = this.btnReportPrint;
            this.btnReportPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportPrint.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReportPrint.CustomImages.Parent = this.btnReportPrint;
            this.btnReportPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnReportPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportPrint.ForeColor = System.Drawing.Color.White;
            this.btnReportPrint.HoverState.Parent = this.btnReportPrint;
            this.btnReportPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPrint.Image")));
            this.btnReportPrint.Location = new System.Drawing.Point(1523, 10);
            this.btnReportPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReportPrint.ShadowDecoration.Parent = this.btnReportPrint;
            this.btnReportPrint.Size = new System.Drawing.Size(53, 49);
            this.btnReportPrint.TabIndex = 340;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // btnStockAlert
            // 
            this.btnStockAlert.Animated = true;
            this.btnStockAlert.BorderRadius = 5;
            this.btnStockAlert.CheckedState.Parent = this.btnStockAlert;
            this.btnStockAlert.CustomImages.Parent = this.btnStockAlert;
            this.btnStockAlert.FillColor = System.Drawing.Color.Crimson;
            this.btnStockAlert.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStockAlert.ForeColor = System.Drawing.Color.White;
            this.btnStockAlert.HoverState.Parent = this.btnStockAlert;
            this.btnStockAlert.Image = ((System.Drawing.Image)(resources.GetObject("btnStockAlert.Image")));
            this.btnStockAlert.Location = new System.Drawing.Point(157, 10);
            this.btnStockAlert.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockAlert.Name = "btnStockAlert";
            this.btnStockAlert.ShadowDecoration.Parent = this.btnStockAlert;
            this.btnStockAlert.Size = new System.Drawing.Size(165, 48);
            this.btnStockAlert.TabIndex = 339;
            this.btnStockAlert.Text = "Stock Alert";
            this.btnStockAlert.Click += new System.EventHandler(this.btnStockAlert_Click);
            // 
            // cmbBrand
            // 
            this.cmbBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBrand.Animated = true;
            this.cmbBrand.AutoRoundedCorners = true;
            this.cmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmbBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbBrand.BorderRadius = 17;
            this.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBrand.FocusedState.Parent = this.cmbBrand;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.HoverState.Parent = this.cmbBrand;
            this.cmbBrand.ItemHeight = 30;
            this.cmbBrand.Items.AddRange(new object[] {
            "Please Select"});
            this.cmbBrand.ItemsAppearance.Parent = this.cmbBrand;
            this.cmbBrand.Location = new System.Drawing.Point(542, 16);
            this.cmbBrand.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.ShadowDecoration.Parent = this.cmbBrand;
            this.cmbBrand.Size = new System.Drawing.Size(265, 36);
            this.cmbBrand.TabIndex = 338;
            this.toolTip.SetToolTip(this.cmbBrand, "Brand");
            this.cmbBrand.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.Animated = true;
            this.cmbCategory.AutoRoundedCorners = true;
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbCategory.BorderRadius = 17;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Category One"});
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(816, 16);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(265, 36);
            this.cmbCategory.TabIndex = 338;
            this.toolTip.SetToolTip(this.cmbCategory, "Category");
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderRadius = 21;
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
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(1090, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 10;
            this.txtSearch.ShadowDecoration.Depth = 1;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(361, 44);
            this.txtSearch.TabIndex = 315;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Animated = true;
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderRadius = 23;
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageSize = new System.Drawing.Size(18, 18);
            this.btnFilter.Location = new System.Drawing.Point(1459, 10);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(53, 49);
            this.btnFilter.TabIndex = 314;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Animated = true;
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BorderRadius = 23;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRefresh.Location = new System.Drawing.Point(483, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(53, 49);
            this.btnRefresh.TabIndex = 314;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStockHistory
            // 
            this.btnStockHistory.Animated = true;
            this.btnStockHistory.BorderRadius = 5;
            this.btnStockHistory.CheckedState.Parent = this.btnStockHistory;
            this.btnStockHistory.CustomImages.Parent = this.btnStockHistory;
            this.btnStockHistory.FillColor = System.Drawing.Color.SeaGreen;
            this.btnStockHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStockHistory.ForeColor = System.Drawing.Color.White;
            this.btnStockHistory.HoverState.Parent = this.btnStockHistory;
            this.btnStockHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStockHistory.ImageSize = new System.Drawing.Size(18, 18);
            this.btnStockHistory.Location = new System.Drawing.Point(324, 10);
            this.btnStockHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockHistory.Name = "btnStockHistory";
            this.btnStockHistory.ShadowDecoration.Parent = this.btnStockHistory;
            this.btnStockHistory.Size = new System.Drawing.Size(115, 49);
            this.btnStockHistory.TabIndex = 314;
            this.btnStockHistory.Text = "HISTORY";
            this.btnStockHistory.Click += new System.EventHandler(this.btnStockHistory_Click);
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
            this.btnNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNew.ImageSize = new System.Drawing.Size(18, 18);
            this.btnNew.Location = new System.Drawing.Point(4, 10);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(152, 48);
            this.btnNew.TabIndex = 314;
            this.btnNew.Text = "ADD NEW";
            this.btnNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlView);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(7, 76);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1585, 501);
            this.pnlContainer.TabIndex = 5;
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // ucStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucStock";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.Size = new System.Drawing.Size(1599, 577);
            this.Load += new System.EventHandler(this.ucStock_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.DataGridView dgvStock;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBrand;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label lblTotalValuation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnStockAlert;
        private System.Windows.Forms.Label chipTotalProduct;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btnReportPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellItemCode;
        private System.Windows.Forms.DataGridViewLinkColumn dgcItemName;
        private System.Windows.Forms.DataGridViewLinkColumn cellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button btnStockHistory;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRecords;
        private Guna.UI2.WinForms.Guna2Button btnGo;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
    }
}
