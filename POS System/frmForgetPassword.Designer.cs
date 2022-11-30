namespace POS_System
{
    partial class frmForgetPassword
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
            Guna.UI2.AnimatorNS.Animation animation8 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPassword));
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAnswer = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCheckUserName = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabResetWizard = new System.Windows.Forms.TabControl();
            this.tabCheckUserName = new System.Windows.Forms.TabPage();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.tabAnswer = new System.Windows.Forms.TabPage();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label6 = new System.Windows.Forms.Label();
            this.tabReset = new System.Windows.Forms.TabPage();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.trsnWizard = new Guna.UI2.WinForms.Guna2Transition();
            this.btnConfirmPasssword = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tabResetWizard.SuspendLayout();
            this.tabCheckUserName.SuspendLayout();
            this.tabAnswer.SuspendLayout();
            this.tabReset.SuspendLayout();
            this.SuspendLayout();
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
            this.trsnWizard.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(28, 28);
            this.btnClose.Location = new System.Drawing.Point(507, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Chip1
            // 
            this.trsnWizard.SetDecoration(this.guna2Chip1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Chip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 0);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(554, 54);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Did you forget your password?";
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Animated = true;
            this.txtQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtQuestion.BorderRadius = 5;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trsnWizard.SetDecoration(this.txtQuestion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuestion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuestion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.DisabledState.Parent = this.txtQuestion;
            this.txtQuestion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.FocusedState.Parent = this.txtQuestion;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuestion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuestion.HoverState.Parent = this.txtQuestion;
            this.txtQuestion.Location = new System.Drawing.Point(24, 120);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderText = "Security Question";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.ShadowDecoration.Parent = this.txtQuestion;
            this.txtQuestion.Size = new System.Drawing.Size(471, 35);
            this.txtQuestion.TabIndex = 324;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 19);
            this.label7.TabIndex = 325;
            this.label7.Text = "Answer the security Question";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 325;
            this.label1.Text = "Your Answer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Animated = true;
            this.txtAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtAnswer.BorderRadius = 5;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trsnWizard.SetDecoration(this.txtAnswer, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtAnswer.Location = new System.Drawing.Point(24, 198);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.PlaceholderText = "Your Answer Please";
            this.txtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.ShadowDecoration.Parent = this.txtAnswer;
            this.txtAnswer.Size = new System.Drawing.Size(471, 35);
            this.txtAnswer.TabIndex = 324;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Animated = true;
            this.btnAnswer.BorderRadius = 8;
            this.btnAnswer.CheckedState.Parent = this.btnAnswer;
            this.btnAnswer.CustomImages.Parent = this.btnAnswer;
            this.trsnWizard.SetDecoration(this.btnAnswer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAnswer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.HoverState.Parent = this.btnAnswer;
            this.btnAnswer.Image = ((System.Drawing.Image)(resources.GetObject("btnAnswer.Image")));
            this.btnAnswer.Location = new System.Drawing.Point(340, 251);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.ShadowDecoration.Parent = this.btnAnswer;
            this.btnAnswer.Size = new System.Drawing.Size(155, 35);
            this.btnAnswer.TabIndex = 329;
            this.btnAnswer.Text = "Confirm";
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 325;
            this.label2.Text = "User Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trsnWizard.SetDecoration(this.txtUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(80, 157);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "Enter your User Name here";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(365, 35);
            this.txtUserName.TabIndex = 324;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // btnCheckUserName
            // 
            this.btnCheckUserName.Animated = true;
            this.btnCheckUserName.BorderRadius = 8;
            this.btnCheckUserName.CheckedState.Parent = this.btnCheckUserName;
            this.btnCheckUserName.CustomImages.Parent = this.btnCheckUserName;
            this.trsnWizard.SetDecoration(this.btnCheckUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCheckUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(98)))), ((int)(((byte)(202)))));
            this.btnCheckUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCheckUserName.ForeColor = System.Drawing.Color.White;
            this.btnCheckUserName.HoverState.Parent = this.btnCheckUserName;
            this.btnCheckUserName.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckUserName.Image")));
            this.btnCheckUserName.Location = new System.Drawing.Point(344, 208);
            this.btnCheckUserName.Name = "btnCheckUserName";
            this.btnCheckUserName.ShadowDecoration.Parent = this.btnCheckUserName;
            this.btnCheckUserName.Size = new System.Drawing.Size(101, 35);
            this.btnCheckUserName.TabIndex = 329;
            this.btnCheckUserName.Text = "Check";
            this.btnCheckUserName.Click += new System.EventHandler(this.btnCheckUserName_Click);
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.BorderRadius = 8;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.trsnWizard.SetDecoration(this.btnReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReset.FillColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(15, 15);
            this.btnReset.Location = new System.Drawing.Point(288, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(155, 35);
            this.btnReset.TabIndex = 334;
            this.btnReset.Text = "Reset Password";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Animated = true;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trsnWizard.SetDecoration(this.txtConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.FocusedState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.HoverState.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Location = new System.Drawing.Point(96, 190);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.ShadowDecoration.Parent = this.txtConfirmPassword;
            this.txtConfirmPassword.Size = new System.Drawing.Size(347, 35);
            this.txtConfirmPassword.TabIndex = 330;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Animated = true;
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.txtNewPassword.BorderRadius = 5;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trsnWizard.SetDecoration(this.txtNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.Parent = this.txtNewPassword;
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.FocusedState.Parent = this.txtNewPassword;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.HoverState.Parent = this.txtNewPassword;
            this.txtNewPassword.Location = new System.Drawing.Point(94, 109);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.ShadowDecoration.Parent = this.txtNewPassword;
            this.txtNewPassword.Size = new System.Drawing.Size(347, 35);
            this.txtNewPassword.TabIndex = 331;
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 332;
            this.label4.Text = "Confirm Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 333;
            this.label3.Text = "New Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabResetWizard
            // 
            this.tabResetWizard.Controls.Add(this.tabCheckUserName);
            this.tabResetWizard.Controls.Add(this.tabAnswer);
            this.tabResetWizard.Controls.Add(this.tabReset);
            this.trsnWizard.SetDecoration(this.tabResetWizard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabResetWizard.Location = new System.Drawing.Point(16, 63);
            this.tabResetWizard.Name = "tabResetWizard";
            this.tabResetWizard.SelectedIndex = 0;
            this.tabResetWizard.Size = new System.Drawing.Size(521, 328);
            this.tabResetWizard.TabIndex = 347;
            this.tabResetWizard.TabStop = false;
            this.tabResetWizard.SelectedIndexChanged += new System.EventHandler(this.tabResetWizard_SelectedIndexChanged);
            // 
            // tabCheckUserName
            // 
            this.tabCheckUserName.BackColor = System.Drawing.Color.White;
            this.tabCheckUserName.Controls.Add(this.guna2Separator1);
            this.tabCheckUserName.Controls.Add(this.label5);
            this.tabCheckUserName.Controls.Add(this.txtUserName);
            this.tabCheckUserName.Controls.Add(this.label2);
            this.tabCheckUserName.Controls.Add(this.btnCheckUserName);
            this.trsnWizard.SetDecoration(this.tabCheckUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabCheckUserName.Location = new System.Drawing.Point(4, 22);
            this.tabCheckUserName.Name = "tabCheckUserName";
            this.tabCheckUserName.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckUserName.Size = new System.Drawing.Size(513, 302);
            this.tabCheckUserName.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.trsnWizard.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.Location = new System.Drawing.Point(29, 62);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(457, 10);
            this.guna2Separator1.TabIndex = 356;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 27);
            this.label5.TabIndex = 355;
            this.label5.Text = "Check your User Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabAnswer
            // 
            this.tabAnswer.BackColor = System.Drawing.Color.White;
            this.tabAnswer.Controls.Add(this.guna2Separator2);
            this.tabAnswer.Controls.Add(this.label6);
            this.tabAnswer.Controls.Add(this.btnAnswer);
            this.tabAnswer.Controls.Add(this.label7);
            this.tabAnswer.Controls.Add(this.label1);
            this.tabAnswer.Controls.Add(this.txtQuestion);
            this.tabAnswer.Controls.Add(this.txtAnswer);
            this.trsnWizard.SetDecoration(this.tabAnswer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabAnswer.Location = new System.Drawing.Point(4, 22);
            this.tabAnswer.Name = "tabAnswer";
            this.tabAnswer.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnswer.Size = new System.Drawing.Size(513, 302);
            this.tabAnswer.TabIndex = 1;
            // 
            // guna2Separator2
            // 
            this.trsnWizard.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.Location = new System.Drawing.Point(29, 52);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(457, 10);
            this.guna2Separator2.TabIndex = 358;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 27);
            this.label6.TabIndex = 357;
            this.label6.Text = "Answer Your Security Question";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabReset
            // 
            this.tabReset.BackColor = System.Drawing.Color.White;
            this.tabReset.Controls.Add(this.btnConfirmPasssword);
            this.tabReset.Controls.Add(this.guna2Separator3);
            this.tabReset.Controls.Add(this.label8);
            this.tabReset.Controls.Add(this.label3);
            this.tabReset.Controls.Add(this.btnReset);
            this.tabReset.Controls.Add(this.label4);
            this.tabReset.Controls.Add(this.txtConfirmPassword);
            this.tabReset.Controls.Add(this.txtNewPassword);
            this.trsnWizard.SetDecoration(this.tabReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabReset.Location = new System.Drawing.Point(4, 22);
            this.tabReset.Name = "tabReset";
            this.tabReset.Size = new System.Drawing.Size(513, 302);
            this.tabReset.TabIndex = 2;
            // 
            // guna2Separator3
            // 
            this.trsnWizard.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.Location = new System.Drawing.Point(30, 48);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(457, 10);
            this.guna2Separator3.TabIndex = 358;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.trsnWizard.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 27);
            this.label8.TabIndex = 357;
            this.label8.Text = "Reset Your Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trsnWizard
            // 
            this.trsnWizard.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.trsnWizard.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.trsnWizard.DefaultAnimation = animation8;
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
            this.trsnWizard.SetDecoration(this.btnConfirmPasssword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnConfirmPasssword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnConfirmPasssword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmPasssword.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPasssword.HoverState.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmPasssword.Image")));
            this.btnConfirmPasssword.Location = new System.Drawing.Point(450, 192);
            this.btnConfirmPasssword.Name = "btnConfirmPasssword";
            this.btnConfirmPasssword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnConfirmPasssword.ShadowDecoration.Parent = this.btnConfirmPasssword;
            this.btnConfirmPasssword.Size = new System.Drawing.Size(30, 30);
            this.btnConfirmPasssword.TabIndex = 359;
            this.btnConfirmPasssword.Click += new System.EventHandler(this.btnConfirmPasssword_Click);
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 415);
            this.Controls.Add(this.tabResetWizard);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Chip1);
            this.trsnWizard.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgetPassword";
            this.Load += new System.EventHandler(this.frmForgetPassword_Load);
            this.tabResetWizard.ResumeLayout(false);
            this.tabCheckUserName.ResumeLayout(false);
            this.tabCheckUserName.PerformLayout();
            this.tabAnswer.ResumeLayout(false);
            this.tabAnswer.PerformLayout();
            this.tabReset.ResumeLayout(false);
            this.tabReset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtAnswer;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAnswer;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnCheckUserName;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabResetWizard;
        private System.Windows.Forms.TabPage tabCheckUserName;
        private System.Windows.Forms.TabPage tabAnswer;
        private System.Windows.Forms.TabPage tabReset;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Transition trsnWizard;
        private Guna.UI2.WinForms.Guna2CircleButton btnConfirmPasssword;
    }
}