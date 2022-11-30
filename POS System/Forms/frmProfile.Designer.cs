namespace POS_System
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbQuestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNIC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConfirmPasssword = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCurrentPasswordShow = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnSavePassword = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Animated = true;
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.White;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnclose.Location = new System.Drawing.Point(792, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 13;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 0);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(844, 54);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "User Profile & Setting";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPassword);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 451);
            this.panel1.TabIndex = 346;
            // 
            // btnPassword
            // 
            this.btnPassword.Animated = true;
            this.btnPassword.BorderRadius = 10;
            this.btnPassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnPassword.CheckedState.Parent = this.btnPassword;
            this.btnPassword.CustomBorderColor = System.Drawing.Color.White;
            this.btnPassword.CustomImages.Parent = this.btnPassword;
            this.btnPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnPassword.ForeColor = System.Drawing.Color.White;
            this.btnPassword.HoverState.Parent = this.btnPassword;
            this.btnPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnPassword.Image")));
            this.btnPassword.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassword.Location = new System.Drawing.Point(10, 79);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.ShadowDecoration.Parent = this.btnPassword;
            this.btnPassword.Size = new System.Drawing.Size(154, 52);
            this.btnPassword.TabIndex = 346;
            this.btnPassword.Text = "Password";
            this.btnPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassword.TextOffset = new System.Drawing.Point(3, 0);
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.BorderRadius = 10;
            this.btnProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfile.Checked = true;
            this.btnProfile.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnProfile.CheckedState.Parent = this.btnProfile;
            this.btnProfile.CustomBorderColor = System.Drawing.Color.White;
            this.btnProfile.CustomImages.Parent = this.btnProfile;
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Parent = this.btnProfile;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.Location = new System.Drawing.Point(11, 21);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(154, 52);
            this.btnProfile.TabIndex = 345;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfile.TextOffset = new System.Drawing.Point(3, 0);
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(169, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 451);
            this.guna2VSeparator1.TabIndex = 347;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(185, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 436);
            this.tabControl1.TabIndex = 346;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cmbQuestion);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtNIC);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtContact);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtAnswer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbQuestion
            // 
            this.cmbQuestion.Animated = true;
            this.cmbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.cmbQuestion.BorderRadius = 5;
            this.cmbQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestion.FocusedColor = System.Drawing.Color.Empty;
            this.cmbQuestion.FocusedState.Parent = this.cmbQuestion;
            this.cmbQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuestion.FormattingEnabled = true;
            this.cmbQuestion.HoverState.Parent = this.cmbQuestion;
            this.cmbQuestion.ItemHeight = 28;
            this.cmbQuestion.Items.AddRange(new object[] {
            "What is your Pet Name?",
            "Where were you born?",
            "Your nick name?"});
            this.cmbQuestion.ItemsAppearance.Parent = this.cmbQuestion;
            this.cmbQuestion.Location = new System.Drawing.Point(183, 83);
            this.cmbQuestion.Name = "cmbQuestion";
            this.cmbQuestion.ShadowDecoration.Parent = this.cmbQuestion;
            this.cmbQuestion.Size = new System.Drawing.Size(433, 34);
            this.cmbQuestion.TabIndex = 359;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnSave.Location = new System.Drawing.Point(183, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(433, 37);
            this.btnSave.TabIndex = 358;
            this.btnSave.Text = "Save";
            this.btnSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderRadius = 5;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(183, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Your Name";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(433, 34);
            this.txtName.TabIndex = 357;
            // 
            // txtNIC
            // 
            this.txtNIC.Animated = true;
            this.txtNIC.BorderColor = System.Drawing.Color.Silver;
            this.txtNIC.BorderRadius = 5;
            this.txtNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIC.DefaultText = "";
            this.txtNIC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNIC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNIC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIC.DisabledState.Parent = this.txtNIC;
            this.txtNIC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIC.FocusedState.Parent = this.txtNIC;
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNIC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIC.HoverState.Parent = this.txtNIC;
            this.txtNIC.Location = new System.Drawing.Point(183, 305);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.PasswordChar = '\0';
            this.txtNIC.PlaceholderText = "National Identity Card Number";
            this.txtNIC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNIC.SelectedText = "";
            this.txtNIC.ShadowDecoration.Parent = this.txtNIC;
            this.txtNIC.Size = new System.Drawing.Size(433, 34);
            this.txtNIC.TabIndex = 352;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 351;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContact
            // 
            this.txtContact.Animated = true;
            this.txtContact.BorderColor = System.Drawing.Color.Silver;
            this.txtContact.BorderRadius = 5;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(183, 250);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "Contact Number";
            this.txtContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.Size = new System.Drawing.Size(433, 34);
            this.txtContact.TabIndex = 353;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(44, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 350;
            this.label7.Text = "Answer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(183, 194);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Enter E-mail Address";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(433, 34);
            this.txtEmail.TabIndex = 354;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(40, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 349;
            this.label9.Text = "E-mail";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Animated = true;
            this.txtAnswer.BorderColor = System.Drawing.Color.Silver;
            this.txtAnswer.BorderRadius = 5;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnswer.DefaultText = "";
            this.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.DisabledState.Parent = this.txtAnswer;
            this.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.FocusedState.Parent = this.txtAnswer;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnswer.HoverState.Parent = this.txtAnswer;
            this.txtAnswer.Location = new System.Drawing.Point(183, 139);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "Answer";
            this.txtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(433, 34);
            this.txtAnswer.TabIndex = 355;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(40, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 23);
            this.label4.TabIndex = 348;
            this.label4.Text = "Contact No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 12F);
            this.label12.Location = new System.Drawing.Point(40, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 23);
            this.label12.TabIndex = 347;
            this.label12.Text = "Security Question";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(40, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 346;
            this.label6.Text = "NIC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnConfirmPasssword);
            this.tabPage2.Controls.Add(this.btnCurrentPasswordShow);
            this.tabPage2.Controls.Add(this.guna2Separator1);
            this.tabPage2.Controls.Add(this.btnSavePassword);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtConfirm);
            this.tabPage2.Controls.Add(this.txtCurrentPassword);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 410);
            this.tabPage2.TabIndex = 1;
            // 
            // btnConfirmPasssword
            // 
            this.btnConfirmPasssword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPasssword.Animated = true;
            this.btnConfirmPasssword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnConfirmPasssword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnConfirmPasssword.CheckedState.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPasssword.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmPasssword.CustomImages.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnConfirmPasssword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmPasssword.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPasssword.HoverState.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmPasssword.Image")));
            this.btnConfirmPasssword.Location = new System.Drawing.Point(488, 265);
            this.btnConfirmPasssword.Name = "btnConfirmPasssword";
            this.btnConfirmPasssword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnConfirmPasssword.ShadowDecoration.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.Size = new System.Drawing.Size(30, 30);
            this.btnConfirmPasssword.TabIndex = 355;
            this.btnConfirmPasssword.Click += new System.EventHandler(this.btnConfirmPasssword_Click);
            // 
            // btnCurrentPasswordShow
            // 
            this.btnCurrentPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentPasswordShow.Animated = true;
            this.btnCurrentPasswordShow.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCurrentPasswordShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnCurrentPasswordShow.CheckedState.Parent = this.btnCurrentPasswordShow;
            this.btnCurrentPasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentPasswordShow.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCurrentPasswordShow.CustomImages.Parent = this.btnCurrentPasswordShow;
            this.btnCurrentPasswordShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnCurrentPasswordShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCurrentPasswordShow.ForeColor = System.Drawing.Color.White;
            this.btnCurrentPasswordShow.HoverState.Parent = this.btnCurrentPasswordShow;
            this.btnCurrentPasswordShow.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrentPasswordShow.Image")));
            this.btnCurrentPasswordShow.Location = new System.Drawing.Point(488, 105);
            this.btnCurrentPasswordShow.Name = "btnCurrentPasswordShow";
            this.btnCurrentPasswordShow.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCurrentPasswordShow.ShadowDecoration.Parent = this.btnCurrentPasswordShow;
            this.btnCurrentPasswordShow.Size = new System.Drawing.Size(30, 30);
            this.btnCurrentPasswordShow.TabIndex = 355;
            this.btnCurrentPasswordShow.Click += new System.EventHandler(this.btnCurrentPasswordShow_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(100, 58);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(457, 10);
            this.guna2Separator1.TabIndex = 354;
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Animated = true;
            this.btnSavePassword.BorderRadius = 5;
            this.btnSavePassword.CheckedState.Parent = this.btnSavePassword;
            this.btnSavePassword.CustomImages.Parent = this.btnSavePassword;
            this.btnSavePassword.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSavePassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSavePassword.ForeColor = System.Drawing.Color.White;
            this.btnSavePassword.HoverState.Parent = this.btnSavePassword;
            this.btnSavePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePassword.Image")));
            this.btnSavePassword.ImageOffset = new System.Drawing.Point(-10, 0);
            this.btnSavePassword.Location = new System.Drawing.Point(184, 318);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.ShadowDecoration.Parent = this.btnSavePassword;
            this.btnSavePassword.Size = new System.Drawing.Size(301, 37);
            this.btnSavePassword.TabIndex = 353;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 350;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 351;
            this.label3.Text = "Change your password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 352;
            this.label8.Text = "Current Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 352;
            this.label5.Text = "New Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Animated = true;
            this.txtConfirm.BorderColor = System.Drawing.Color.Silver;
            this.txtConfirm.BorderRadius = 5;
            this.txtConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirm.DefaultText = "";
            this.txtConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirm.DisabledState.Parent = this.txtConfirm;
            this.txtConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirm.FocusedState.Parent = this.txtConfirm;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirm.HoverState.Parent = this.txtConfirm;
            this.txtConfirm.Location = new System.Drawing.Point(184, 264);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '\0';
            this.txtConfirm.PlaceholderText = "Confirm your password";
            this.txtConfirm.SelectedText = "";
            this.txtConfirm.ShadowDecoration.Parent = this.txtConfirm;
            this.txtConfirm.Size = new System.Drawing.Size(301, 33);
            this.txtConfirm.TabIndex = 348;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Animated = true;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtCurrentPassword.BorderRadius = 5;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.DefaultText = "";
            this.txtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.DisabledState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.FocusedState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.HoverState.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Location = new System.Drawing.Point(184, 104);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '\0';
            this.txtCurrentPassword.PlaceholderText = "Enter your current password";
            this.txtCurrentPassword.SelectedText = "";
            this.txtCurrentPassword.ShadowDecoration.Parent = this.txtCurrentPassword;
            this.txtCurrentPassword.Size = new System.Drawing.Size(301, 33);
            this.txtCurrentPassword.TabIndex = 349;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(184, 182);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Enter your new password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(301, 33);
            this.txtPassword.TabIndex = 349;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 505);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Chip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfile";
            this.Text = "profile";
            this.Shown += new System.EventHandler(this.profile_Shown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnPassword;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtNIC;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnSavePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuestion;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPassword;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCurrentPasswordShow;
        private Guna.UI2.WinForms.Guna2CircleButton btnConfirmPasssword;
    }
}