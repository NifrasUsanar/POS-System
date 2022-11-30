namespace POS_System
{
    partial class frmPurchaseOrderPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReport = new POS_System.dsReport();
            this.dtPurchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtStoreDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dsPurchaseOrder";
            reportDataSource3.Value = this.dtPurchaseOrderBindingSource;
            reportDataSource4.Name = "dsStore";
            reportDataSource4.Value = this.dtStoreDetailsBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "POS_System.rptPurchaseOrder.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(402, 385);
            this.rptViewer.TabIndex = 360;
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtPurchaseOrderBindingSource
            // 
            this.dtPurchaseOrderBindingSource.DataMember = "dtPurchaseOrder";
            this.dtPurchaseOrderBindingSource.DataSource = this.dsReport;
            // 
            // dtStoreDetailsBindingSource
            // 
            this.dtStoreDetailsBindingSource.DataMember = "dtStoreDetails";
            this.dtStoreDetailsBindingSource.DataSource = this.dsReport;
            // 
            // frmPurchaseOrderPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 385);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmPurchaseOrderPrint";
            this.Text = "Order Print";
            this.Load += new System.EventHandler(this.frmPurchaseOrderPrint_Load);
            this.Shown += new System.EventHandler(this.frmPurchaseOrderPrint_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPurchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStoreDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource dtPurchaseOrderBindingSource;
        private dsReport dsReport;
        private System.Windows.Forms.BindingSource dtStoreDetailsBindingSource;
    }
}