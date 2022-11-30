namespace POS_System
{
    partial class frmSummaryReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryReport));
            this.dtProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSummaryReport = new POS_System.dsSummaryReport();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtSaleSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtVednorPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCustomerPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtProfitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleSummaryBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtVednorPaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerPaymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtProfitBindingSource
            // 
            this.dtProfitBindingSource.DataMember = "dtProfit";
            this.dtProfitBindingSource.DataSource = this.dsSummaryReport;
            // 
            // dsSummaryReport
            // 
            this.dsSummaryReport.DataSetName = "dsSummaryReport";
            this.dsSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "dsSummaryReport";
            reportDataSource4.Value = this.dtProfitBindingSource;
            reportDataSource5.Name = "dsVendor";
            reportDataSource5.Value = this.dtVednorPaymentBindingSource;
            reportDataSource6.Name = "dsCustomer";
            reportDataSource6.Value = this.dtCustomerPaymentBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "POS_System.rptSummaryReport.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 53);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(833, 387);
            this.rptViewer.TabIndex = 362;
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Animated = true;
            this.dtpStart.BackColor = System.Drawing.Color.White;
            this.dtpStart.BorderRadius = 5;
            this.dtpStart.CheckedState.Parent = this.dtpStart;
            this.dtpStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.HoverState.Parent = this.dtpStart;
            this.dtpStart.Location = new System.Drawing.Point(277, 8);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(131, 36);
            this.dtpStart.TabIndex = 335;
            this.dtpStart.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Animated = true;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(577, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 338;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Animated = true;
            this.dtpEnd.BackColor = System.Drawing.Color.White;
            this.dtpEnd.BorderRadius = 5;
            this.dtpEnd.CheckedState.Parent = this.dtpEnd;
            this.dtpEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.White;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.HoverState.Parent = this.dtpEnd;
            this.dtpEnd.Location = new System.Drawing.Point(437, 8);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(135, 36);
            this.dtpEnd.TabIndex = 334;
            this.dtpEnd.Value = new System.DateTime(2020, 7, 18, 1, 30, 20, 432);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 337;
            this.label3.Text = "Filter by Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(406, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 40);
            this.label4.TabIndex = 336;
            this.label4.Text = "TO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 53);
            this.panel1.TabIndex = 361;
            // 
            // dtVednorPaymentBindingSource
            // 
            this.dtVednorPaymentBindingSource.DataMember = "dtVednorPayment";
            this.dtVednorPaymentBindingSource.DataSource = this.dsSummaryReport;
            // 
            // dtCustomerPaymentBindingSource
            // 
            this.dtCustomerPaymentBindingSource.DataMember = "dtCustomerPayment";
            this.dtCustomerPaymentBindingSource.DataSource = this.dsSummaryReport;
            // 
            // frmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 440);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.panel1);
            this.Name = "frmSummaryReport";
            this.Text = "SUMMARY REPORT";
            this.Load += new System.EventHandler(this.frmSummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProfitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleSummaryBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtVednorPaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerPaymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource dtSaleSummaryBindingSource;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private dsSummaryReport dsSummaryReport;
        private System.Windows.Forms.BindingSource dtProfitBindingSource;
        private System.Windows.Forms.BindingSource dtVednorPaymentBindingSource;
        private System.Windows.Forms.BindingSource dtCustomerPaymentBindingSource;
    }
}