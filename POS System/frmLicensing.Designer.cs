namespace POS_System
{
    partial class frmLicensing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicensing));
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtLicense = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblActivation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.lblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Location = new System.Drawing.Point(350, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtLicense
            // 
            this.txtLicense.Animated = true;
            this.txtLicense.BackColor = System.Drawing.Color.Transparent;
            this.txtLicense.BorderRadius = 6;
            this.txtLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicense.DefaultText = "";
            this.txtLicense.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicense.DisabledState.Parent = this.txtLicense;
            this.txtLicense.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLicense.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicense.FocusedState.Parent = this.txtLicense;
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLicense.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLicense.HoverState.Parent = this.txtLicense;
            this.txtLicense.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtLicense.IconLeft")));
            this.txtLicense.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.txtLicense.Location = new System.Drawing.Point(41, 196);
            this.txtLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.PasswordChar = '\0';
            this.txtLicense.PlaceholderText = "License Key";
            this.txtLicense.SelectedText = "";
            this.txtLicense.ShadowDecoration.Parent = this.txtLicense;
            this.txtLicense.Size = new System.Drawing.Size(321, 47);
            this.txtLicense.TabIndex = 6;
            this.txtLicense.TextOffset = new System.Drawing.Point(2, 0);
            // 
            // lblActivation
            // 
            this.lblActivation.BackColor = System.Drawing.Color.Transparent;
            this.lblActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivation.Location = new System.Drawing.Point(90, 123);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(222, 27);
            this.lblActivation.TabIndex = 7;
            this.lblActivation.Text = "Your License is Activated";
            // 
            // btnActivate
            // 
            this.btnActivate.Animated = true;
            this.btnActivate.BackColor = System.Drawing.Color.Transparent;
            this.btnActivate.BorderRadius = 6;
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(88, 263);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.BorderRadius = 50;
            this.btnActivate.ShadowDecoration.Depth = 50;
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(20);
            this.btnActivate.Size = new System.Drawing.Size(227, 43);
            this.btnActivate.TabIndex = 8;
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(41, 167);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(321, 24);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "This License will be Expired on 2020-09-30";
            this.lblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLicensing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 379);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblActivation);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLicensing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicensing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblActivation;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMessage;
    }
}