namespace POS_System
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.categary_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.categoty_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(381, 9);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2CircleButton1.TabIndex = 11;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // categary_code
            // 
            this.categary_code.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categary_code.Animated = true;
            this.categary_code.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.categary_code.BorderRadius = 5;
            this.categary_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categary_code.DefaultText = "";
            this.categary_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categary_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categary_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categary_code.DisabledState.Parent = this.categary_code;
            this.categary_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categary_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categary_code.FocusedState.Parent = this.categary_code;
            this.categary_code.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.categary_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categary_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categary_code.HoverState.Parent = this.categary_code;
            this.categary_code.Location = new System.Drawing.Point(158, 89);
            this.categary_code.Margin = new System.Windows.Forms.Padding(4);
            this.categary_code.Name = "categary_code";
            this.categary_code.PasswordChar = '\0';
            this.categary_code.PlaceholderText = "Enter Category Code ";
            this.categary_code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categary_code.SelectedText = "";
            this.categary_code.ShadowDecoration.Parent = this.categary_code;
            this.categary_code.Size = new System.Drawing.Size(247, 35);
            this.categary_code.TabIndex = 322;
            // 
            // categoty_name
            // 
            this.categoty_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoty_name.Animated = true;
            this.categoty_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.categoty_name.BorderRadius = 5;
            this.categoty_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoty_name.DefaultText = "";
            this.categoty_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoty_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoty_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoty_name.DisabledState.Parent = this.categoty_name;
            this.categoty_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoty_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoty_name.FocusedState.Parent = this.categoty_name;
            this.categoty_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.categoty_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoty_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoty_name.HoverState.Parent = this.categoty_name;
            this.categoty_name.Location = new System.Drawing.Point(158, 145);
            this.categoty_name.Margin = new System.Windows.Forms.Padding(4);
            this.categoty_name.Name = "categoty_name";
            this.categoty_name.PasswordChar = '\0';
            this.categoty_name.PlaceholderText = "Enter Category Name";
            this.categoty_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoty_name.SelectedText = "";
            this.categoty_name.ShadowDecoration.Parent = this.categoty_name;
            this.categoty_name.Size = new System.Drawing.Size(247, 35);
            this.categoty_name.TabIndex = 322;
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
            this.guna2Chip1.Size = new System.Drawing.Size(433, 58);
            this.guna2Chip1.TabIndex = 324;
            this.guna2Chip1.Text = "ADD / EDIT CATEGORY";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSave.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(158, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(247, 40);
            this.btnSave.TabIndex = 323;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 264);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.categoty_name);
            this.Controls.Add(this.categary_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORY INFORMATION";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.frmCategory_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox categoty_name;
        private Guna.UI2.WinForms.Guna2TextBox categary_code;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}