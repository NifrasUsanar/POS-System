namespace POS_System
{
    partial class frmBillProfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillProfit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.dgvPOS = new System.Windows.Forms.DataGridView();
            this.cellCartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellQuantity = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cellDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).BeginInit();
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
            this.guna2Chip1.Size = new System.Drawing.Size(869, 54);
            this.guna2Chip1.TabIndex = 15;
            this.guna2Chip1.Text = "Detailed Bill";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
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
            this.btnClose.Location = new System.Drawing.Point(823, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 16;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Chip1;
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.White;
            this.lblTotalProfit.Location = new System.Drawing.Point(667, 422);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(182, 41);
            this.lblTotalProfit.TabIndex = 312;
            this.lblTotalProfit.Text = "Rs. 0";
            this.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 313;
            this.label1.Text = "Total Profit:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 313;
            this.label2.Text = "Bill Total :";
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(181, 433);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(51, 20);
            this.lblBillTotal.TabIndex = 313;
            this.lblBillTotal.Text = "Rs. 0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 313;
            this.label4.Text = "Total Cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(399, 434);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(51, 20);
            this.lblTotalCost.TabIndex = 313;
            this.lblTotalCost.Text = "Rs. 0";
            // 
            // dgvPOS
            // 
            this.dgvPOS.AllowUserToAddRows = false;
            this.dgvPOS.AllowUserToDeleteRows = false;
            this.dgvPOS.AllowUserToResizeColumns = false;
            this.dgvPOS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPOS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvPOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPOS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPOS.ColumnHeadersHeight = 35;
            this.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellCartID,
            this.cellItemID,
            this.Column4,
            this.cellProductName,
            this.cellPrice,
            this.cellQuantity,
            this.cellDiscount,
            this.cellTotal,
            this.cellBatchNo,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle7.NullValue = "...";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPOS.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPOS.EnableHeadersVisualStyles = false;
            this.dgvPOS.GridColor = System.Drawing.Color.White;
            this.dgvPOS.Location = new System.Drawing.Point(12, 60);
            this.dgvPOS.MultiSelect = false;
            this.dgvPOS.Name = "dgvPOS";
            this.dgvPOS.ReadOnly = true;
            this.dgvPOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPOS.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPOS.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPOS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvPOS.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPOS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPOS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dgvPOS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.dgvPOS.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.RowTemplate.DividerHeight = 1;
            this.dgvPOS.RowTemplate.Height = 40;
            this.dgvPOS.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOS.ShowCellToolTips = false;
            this.dgvPOS.Size = new System.Drawing.Size(845, 343);
            this.dgvPOS.TabIndex = 314;
            this.dgvPOS.TabStop = false;
            // 
            // cellCartID
            // 
            this.cellCartID.DataPropertyName = "cart_id";
            this.cellCartID.HeaderText = "#";
            this.cellCartID.Name = "cellCartID";
            this.cellCartID.ReadOnly = true;
            this.cellCartID.Visible = false;
            // 
            // cellItemID
            // 
            this.cellItemID.DataPropertyName = "item_id";
            this.cellItemID.HeaderText = "ItemID";
            this.cellItemID.Name = "cellItemID";
            this.cellItemID.ReadOnly = true;
            this.cellItemID.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "indirect_profit";
            this.Column4.HeaderText = "Indirect Profit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // cellProductName
            // 
            this.cellProductName.DataPropertyName = "itm_name";
            this.cellProductName.FillWeight = 150F;
            this.cellProductName.HeaderText = "Product";
            this.cellProductName.Name = "cellProductName";
            this.cellProductName.ReadOnly = true;
            // 
            // cellPrice
            // 
            this.cellPrice.DataPropertyName = "item_price";
            this.cellPrice.HeaderText = "Price";
            this.cellPrice.Name = "cellPrice";
            this.cellPrice.ReadOnly = true;
            // 
            // cellQuantity
            // 
            this.cellQuantity.DataPropertyName = "item_quantity";
            this.cellQuantity.FillWeight = 50F;
            this.cellQuantity.HeaderText = "Qty";
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ReadOnly = true;
            this.cellQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cellDiscount
            // 
            this.cellDiscount.DataPropertyName = "item_discount";
            this.cellDiscount.FillWeight = 70F;
            this.cellDiscount.HeaderText = "Disc";
            this.cellDiscount.Name = "cellDiscount";
            this.cellDiscount.ReadOnly = true;
            // 
            // cellTotal
            // 
            this.cellTotal.DataPropertyName = "total";
            dataGridViewCellStyle3.Format = "N2";
            this.cellTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.cellTotal.FillWeight = 80F;
            this.cellTotal.HeaderText = "Total";
            this.cellTotal.Name = "cellTotal";
            this.cellTotal.ReadOnly = true;
            // 
            // cellBatchNo
            // 
            this.cellBatchNo.DataPropertyName = "batch_no";
            this.cellBatchNo.HeaderText = "Batch No";
            this.cellBatchNo.Name = "cellBatchNo";
            this.cellBatchNo.ReadOnly = true;
            this.cellBatchNo.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "unit_cost";
            dataGridViewCellStyle4.Format = "N2";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Unit Cost";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "line_cost";
            dataGridViewCellStyle5.Format = "N2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Line Cost";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "profit";
            dataGridViewCellStyle6.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "Line Profit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmBillProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 472);
            this.Controls.Add(this.dgvPOS);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBillTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBillProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBillProfit";
            this.Shown += new System.EventHandler(this.frmBillProfit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellCartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPrice;
        private System.Windows.Forms.DataGridViewLinkColumn cellQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}