namespace POS_System
{
    partial class frmBillPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSalesView = new POS_System.dsSalesView();
            this.dtSalesItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtStoreDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalesItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSalesBindingSource
            // 
            this.dtSalesBindingSource.DataMember = "dtSales";
            this.dtSalesBindingSource.DataSource = this.dsSalesView;
            // 
            // dsSalesView
            // 
            this.dsSalesView.DataSetName = "dsSalesView";
            this.dsSalesView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSalesItemBindingSource
            // 
            this.dtSalesItemBindingSource.DataMember = "dtSalesItem";
            this.dtSalesItemBindingSource.DataSource = this.dsSalesView;
            // 
            // dtStoreDetailsBindingSource
            // 
            this.dtStoreDetailsBindingSource.DataMember = "dtStoreDetails";
            this.dtStoreDetailsBindingSource.DataSource = this.dsSalesView;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsBill";
            reportDataSource1.Value = this.dtSalesBindingSource;
            reportDataSource2.Name = "dsItemList";
            reportDataSource2.Value = this.dtSalesItemBindingSource;
            reportDataSource3.Name = "dsStore";
            reportDataSource3.Value = this.dtStoreDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_System.rptBillReciept.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(706, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 538);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBillPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Print";
            this.Load += new System.EventHandler(this.frmBillPrint_Load);
            this.Shown += new System.EventHandler(this.frmBillPrint_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalesItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtSalesBindingSource;
        private dsSalesView dsSalesView;
        private System.Windows.Forms.BindingSource dtSalesItemBindingSource;
        private System.Windows.Forms.BindingSource dtStoreDetailsBindingSource;
    }
}