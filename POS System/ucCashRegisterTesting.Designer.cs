namespace POS_System
{
    partial class ucCashRegisterTesting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.cmbCashRegister = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtOpenCash = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.cmbCashRegister);
            this.groupBox1.Controls.Add(this.txtOpenCash);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 107);
            this.groupBox1.TabIndex = 355;
            this.groupBox1.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Animated = true;
            this.btnSelect.BorderRadius = 6;
            this.btnSelect.CheckedState.Parent = this.btnSelect;
            this.btnSelect.CustomImages.Parent = this.btnSelect;
            this.btnSelect.Enabled = false;
            this.btnSelect.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.Parent = this.btnSelect;
            this.btnSelect.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSelect.Location = new System.Drawing.Point(230, 47);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(94, 36);
            this.btnSelect.TabIndex = 355;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // cmbCashRegister
            // 
            this.cmbCashRegister.Animated = true;
            this.cmbCashRegister.BackColor = System.Drawing.Color.Transparent;
            this.cmbCashRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbCashRegister.BorderRadius = 5;
            this.cmbCashRegister.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCashRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashRegister.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCashRegister.FocusedState.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCashRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCashRegister.FormattingEnabled = true;
            this.cmbCashRegister.HoverState.Parent = this.cmbCashRegister;
            this.cmbCashRegister.ItemHeight = 30;
            this.cmbCashRegister.ItemsAppearance.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Location = new System.Drawing.Point(13, 47);
            this.cmbCashRegister.Name = "cmbCashRegister";
            this.cmbCashRegister.ShadowDecoration.Parent = this.cmbCashRegister;
            this.cmbCashRegister.Size = new System.Drawing.Size(211, 36);
            this.cmbCashRegister.TabIndex = 350;
            // 
            // txtOpenCash
            // 
            this.txtOpenCash.Animated = true;
            this.txtOpenCash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtOpenCash.BorderRadius = 5;
            this.txtOpenCash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpenCash.DefaultText = "0";
            this.txtOpenCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOpenCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOpenCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOpenCash.DisabledState.Parent = this.txtOpenCash;
            this.txtOpenCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOpenCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOpenCash.FocusedState.Parent = this.txtOpenCash;
            this.txtOpenCash.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOpenCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOpenCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOpenCash.HoverState.Parent = this.txtOpenCash;
            this.txtOpenCash.Location = new System.Drawing.Point(333, 48);
            this.txtOpenCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpenCash.Name = "txtOpenCash";
            this.txtOpenCash.PasswordChar = '\0';
            this.txtOpenCash.PlaceholderText = "";
            this.txtOpenCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOpenCash.SelectedText = "";
            this.txtOpenCash.SelectionStart = 1;
            this.txtOpenCash.ShadowDecoration.Parent = this.txtOpenCash;
            this.txtOpenCash.Size = new System.Drawing.Size(114, 35);
            this.txtOpenCash.TabIndex = 351;
            this.txtOpenCash.Tag = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 23);
            this.label5.TabIndex = 352;
            this.label5.Text = "Choose and Select your Register";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 352;
            this.label2.Text = "Opening Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucCashRegisterTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucCashRegisterTesting";
            this.Size = new System.Drawing.Size(545, 247);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCashRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtOpenCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}
