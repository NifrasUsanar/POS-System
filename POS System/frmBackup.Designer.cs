namespace POS_System
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtRestore = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.txtBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSelectFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectFolder = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnclose);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(808, 61);
            this.pnlTop.TabIndex = 370;
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
            this.btnclose.Location = new System.Drawing.Point(759, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 14;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "Backup and Restore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipse
            // 
            this.gunaElipse.BorderRadius = 10;
            this.gunaElipse.TargetControl = this;
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProgress.Location = new System.Drawing.Point(10, 176);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProgress.Size = new System.Drawing.Size(776, 305);
            this.txtProgress.TabIndex = 377;
            // 
            // txtRestore
            // 
            this.txtRestore.Animated = true;
            this.txtRestore.BorderColor = System.Drawing.Color.Silver;
            this.txtRestore.BorderRadius = 5;
            this.txtRestore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestore.DefaultText = "NO FOLDER SELECTED";
            this.txtRestore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestore.DisabledState.Parent = this.txtRestore;
            this.txtRestore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestore.FocusedState.Parent = this.txtRestore;
            this.txtRestore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRestore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestore.HoverState.Parent = this.txtRestore;
            this.txtRestore.Location = new System.Drawing.Point(220, 122);
            this.txtRestore.Margin = new System.Windows.Forms.Padding(4);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.PasswordChar = '\0';
            this.txtRestore.PlaceholderText = "";
            this.txtRestore.ReadOnly = true;
            this.txtRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestore.SelectedText = "";
            this.txtRestore.SelectionStart = 18;
            this.txtRestore.ShadowDecoration.Parent = this.txtRestore;
            this.txtRestore.Size = new System.Drawing.Size(449, 38);
            this.txtRestore.TabIndex = 375;
            // 
            // btnRestore
            // 
            this.btnRestore.Animated = true;
            this.btnRestore.BorderRadius = 5;
            this.btnRestore.CheckedState.Parent = this.btnRestore;
            this.btnRestore.CustomImages.Parent = this.btnRestore;
            this.btnRestore.FillColor = System.Drawing.Color.SeaGreen;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.Parent = this.btnRestore;
            this.btnRestore.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRestore.Location = new System.Drawing.Point(676, 122);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShadowDecoration.Parent = this.btnRestore;
            this.btnRestore.Size = new System.Drawing.Size(112, 38);
            this.btnRestore.TabIndex = 371;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Animated = true;
            this.txtBackup.BorderColor = System.Drawing.Color.Silver;
            this.txtBackup.BorderRadius = 5;
            this.txtBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackup.DefaultText = "NO FOLDER SELECTED";
            this.txtBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackup.DisabledState.Parent = this.txtBackup;
            this.txtBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackup.FocusedState.Parent = this.txtBackup;
            this.txtBackup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackup.HoverState.Parent = this.txtBackup;
            this.txtBackup.Location = new System.Drawing.Point(220, 68);
            this.txtBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.PasswordChar = '\0';
            this.txtBackup.PlaceholderText = "";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackup.SelectedText = "";
            this.txtBackup.SelectionStart = 18;
            this.txtBackup.ShadowDecoration.Parent = this.txtBackup;
            this.txtBackup.Size = new System.Drawing.Size(449, 38);
            this.txtBackup.TabIndex = 376;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Animated = true;
            this.btnSelectFile.BorderRadius = 5;
            this.btnSelectFile.CheckedState.Parent = this.btnSelectFile;
            this.btnSelectFile.CustomImages.Parent = this.btnSelectFile;
            this.btnSelectFile.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.HoverState.Parent = this.btnSelectFile;
            this.btnSelectFile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelectFile.Location = new System.Drawing.Point(10, 122);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.ShadowDecoration.Parent = this.btnSelectFile;
            this.btnSelectFile.Size = new System.Drawing.Size(203, 38);
            this.btnSelectFile.TabIndex = 372;
            this.btnSelectFile.Text = "SELECT FILE TO RESTORE";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Animated = true;
            this.btnBackup.BorderRadius = 5;
            this.btnBackup.CheckedState.Parent = this.btnBackup;
            this.btnBackup.CustomImages.Parent = this.btnBackup;
            this.btnBackup.FillColor = System.Drawing.Color.SeaGreen;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.Parent = this.btnBackup;
            this.btnBackup.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBackup.Location = new System.Drawing.Point(676, 68);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ShadowDecoration.Parent = this.btnBackup;
            this.btnBackup.Size = new System.Drawing.Size(112, 38);
            this.btnBackup.TabIndex = 373;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Animated = true;
            this.btnSelectFolder.BorderRadius = 5;
            this.btnSelectFolder.CheckedState.Parent = this.btnSelectFolder;
            this.btnSelectFolder.CustomImages.Parent = this.btnSelectFolder;
            this.btnSelectFolder.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectFolder.HoverState.Parent = this.btnSelectFolder;
            this.btnSelectFolder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelectFolder.Location = new System.Drawing.Point(10, 68);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.ShadowDecoration.Parent = this.btnSelectFolder;
            this.btnSelectFolder.Size = new System.Drawing.Size(203, 38);
            this.btnSelectFolder.TabIndex = 374;
            this.btnSelectFolder.Text = "SELECT A FOLDER TO BACKUP";
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 553);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse gunaElipse;
        private System.Windows.Forms.TextBox txtProgress;
        private Guna.UI2.WinForms.Guna2TextBox txtRestore;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private Guna.UI2.WinForms.Guna2TextBox txtBackup;
        private Guna.UI2.WinForms.Guna2Button btnSelectFile;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnSelectFolder;
    }
}