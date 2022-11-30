namespace POS_System
{
    partial class frmGlobalReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlobalReport));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnclose);
            this.pnlTop.Controls.Add(this.lblReportTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(942, 61);
            this.pnlTop.TabIndex = 358;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Animated = true;
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.White;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(893, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 14;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportTitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.White;
            this.lblReportTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(942, 61);
            this.lblReportTitle.TabIndex = 15;
            this.lblReportTitle.Text = "Report";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lblReportTitle;
            // 
            // gunaElipse
            // 
            this.gunaElipse.BorderRadius = 10;
            this.gunaElipse.TargetControl = this;
            // 
            // rptViewer
            // 
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 61);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(942, 727);
            this.rptViewer.TabIndex = 359;
            // 
            // frmGlobalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 788);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGlobalReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGlobalReport";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.frmGlobalReport_Shown);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Label lblReportTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse gunaElipse;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}