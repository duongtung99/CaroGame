using System.Windows.Forms;

namespace CaroGame
{
    partial class FormCaro
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
            this.processbartime = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtSignup = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.formName = new System.Windows.Forms.Label();
            this.txtChecklog = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txt_Log2 = new System.Windows.Forms.TextBox();
            this.txt_Log1 = new System.Windows.Forms.TextBox();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtSignin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.repassword = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.fullname1 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.Label();
            this.username1 = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panelSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // processbartime
            // 
            this.processbartime.Tick += new System.EventHandler(this.processbar_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(47, 620);
            this.progressBar1.MarqueeAnimationSpeed = 1000;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1072, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.txtSignup);
            this.panelLogin.Controls.Add(this.btnCancel);
            this.panelLogin.Controls.Add(this.password);
            this.panelLogin.Controls.Add(this.username);
            this.panelLogin.Controls.Add(this.formName);
            this.panelLogin.Controls.Add(this.txtChecklog);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txt_Log2);
            this.panelLogin.Controls.Add(this.txt_Log1);
            this.panelLogin.Location = new System.Drawing.Point(343, 96);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(468, 320);
            this.panelLogin.TabIndex = 45;
            // 
            // txtSignup
            // 
            this.txtSignup.AutoSize = true;
            this.txtSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSignup.Location = new System.Drawing.Point(125, 281);
            this.txtSignup.Name = "txtSignup";
            this.txtSignup.Size = new System.Drawing.Size(163, 13);
            this.txtSignup.TabIndex = 36;
            this.txtSignup.Text = "click here to create new account";
            this.txtSignup.Click += new System.EventHandler(this.txtSignup_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(242, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 45);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(101, 136);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 17);
            this.password.TabIndex = 34;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(101, 70);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(69, 17);
            this.username.TabIndex = 33;
            this.username.Text = "Username";
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.Color.Transparent;
            this.formName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Underline);
            this.formName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.formName.Location = new System.Drawing.Point(176, 14);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(116, 42);
            this.formName.TabIndex = 32;
            this.formName.Text = "Login";
            // 
            // txtChecklog
            // 
            this.txtChecklog.AutoSize = true;
            this.txtChecklog.BackColor = System.Drawing.Color.Transparent;
            this.txtChecklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChecklog.ForeColor = System.Drawing.Color.Red;
            this.txtChecklog.Location = new System.Drawing.Point(125, 197);
            this.txtChecklog.Name = "txtChecklog";
            this.txtChecklog.Size = new System.Drawing.Size(27, 15);
            this.txtChecklog.TabIndex = 30;
            this.txtChecklog.Text = "null";
            this.txtChecklog.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(104, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_Log2
            // 
            this.txt_Log2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Log2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Log2.Location = new System.Drawing.Point(104, 157);
            this.txt_Log2.Name = "txt_Log2";
            this.txt_Log2.Size = new System.Drawing.Size(237, 26);
            this.txt_Log2.TabIndex = 2;
            this.txt_Log2.Enter += new System.EventHandler(this.txt_Log2_Enter);
            // 
            // txt_Log1
            // 
            this.txt_Log1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Log1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Log1.Location = new System.Drawing.Point(104, 90);
            this.txt_Log1.Name = "txt_Log1";
            this.txt_Log1.Size = new System.Drawing.Size(237, 26);
            this.txt_Log1.TabIndex = 1;
            this.txt_Log1.Enter += new System.EventHandler(this.txt_Log1_Enter);
            // 
            // panelSignup
            // 
            this.panelSignup.BackColor = System.Drawing.Color.Transparent;
            this.panelSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSignup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSignup.Controls.Add(this.lblCheck);
            this.panelSignup.Controls.Add(this.txtSignin);
            this.panelSignup.Controls.Add(this.btnExit);
            this.panelSignup.Controls.Add(this.txtEmail);
            this.panelSignup.Controls.Add(this.Email);
            this.panelSignup.Controls.Add(this.repassword);
            this.panelSignup.Controls.Add(this.password2);
            this.panelSignup.Controls.Add(this.txtFullname);
            this.panelSignup.Controls.Add(this.fullname1);
            this.panelSignup.Controls.Add(this.password1);
            this.panelSignup.Controls.Add(this.username1);
            this.panelSignup.Controls.Add(this.Signup);
            this.panelSignup.Controls.Add(this.btnSignup);
            this.panelSignup.Controls.Add(this.txtPassword);
            this.panelSignup.Controls.Add(this.txtUsername);
            this.panelSignup.Location = new System.Drawing.Point(343, 83);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(468, 473);
            this.panelSignup.TabIndex = 47;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(129, 365);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(41, 13);
            this.lblCheck.TabIndex = 45;
            this.lblCheck.Text = "label1";
            // 
            // txtSignin
            // 
            this.txtSignin.AutoSize = true;
            this.txtSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSignin.Location = new System.Drawing.Point(179, 445);
            this.txtSignin.Name = "txtSignin";
            this.txtSignin.Size = new System.Drawing.Size(90, 13);
            this.txtSignin.TabIndex = 44;
            this.txtSignin.Text = "click here to login";
            this.txtSignin.Click += new System.EventHandler(this.txtSignin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(242, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 45);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Cancel";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(104, 322);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 26);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email.Location = new System.Drawing.Point(104, 302);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 41;
            this.Email.Text = "Email";
            // 
            // repassword
            // 
            this.repassword.AutoSize = true;
            this.repassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.repassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.repassword.Location = new System.Drawing.Point(104, 239);
            this.repassword.Name = "repassword";
            this.repassword.Size = new System.Drawing.Size(86, 17);
            this.repassword.TabIndex = 40;
            this.repassword.Text = "Re-Password";
            // 
            // password2
            // 
            this.password2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password2.Location = new System.Drawing.Point(104, 259);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(261, 26);
            this.password2.TabIndex = 39;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFullname.Location = new System.Drawing.Point(104, 87);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(261, 26);
            this.txtFullname.TabIndex = 38;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            // 
            // fullname1
            // 
            this.fullname1.AutoSize = true;
            this.fullname1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname1.ForeColor = System.Drawing.Color.Black;
            this.fullname1.Location = new System.Drawing.Point(101, 71);
            this.fullname1.Name = "fullname1";
            this.fullname1.Size = new System.Drawing.Size(69, 17);
            this.fullname1.TabIndex = 37;
            this.fullname1.Text = "Full name";
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.password1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password1.Location = new System.Drawing.Point(103, 180);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(66, 17);
            this.password1.TabIndex = 34;
            this.password1.Text = "Password";
            // 
            // username1
            // 
            this.username1.AutoSize = true;
            this.username1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.username1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username1.Location = new System.Drawing.Point(101, 126);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(69, 17);
            this.username1.TabIndex = 33;
            this.username1.Text = "Username";
            // 
            // Signup
            // 
            this.Signup.AutoSize = true;
            this.Signup.BackColor = System.Drawing.Color.Transparent;
            this.Signup.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Signup.Location = new System.Drawing.Point(158, 15);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(171, 42);
            this.Signup.TabIndex = 32;
            this.Signup.Text = "Register";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(104, 381);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(121, 45);
            this.btnSignup.TabIndex = 43;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(104, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 26);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(104, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(259, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // FormCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaroGame.Properties.Resources.bglogin__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 740);
            this.Controls.Add(this.panelSignup);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.progressBar1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1171, 779);
            this.Name = "FormCaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCaro_FormClosing);
            this.Load += new System.EventHandler(this.FormCaro_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer processbartime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Panel panelLogin;
        private Label txtSignup;
        private Button btnCancel;
        private Label password;
        private Label username;
        private Label formName;
        private Label txtChecklog;
        private Button btnLogin;
        private TextBox txt_Log2;
        private TextBox txt_Log1;
        private Panel panelSignup;
        private Label txtSignin;
        private Button btnExit;
        private TextBox txtEmail;
        private Label Email;
        private Label repassword;
        private TextBox password2;
        private TextBox txtFullname;
        private Label fullname1;
        private Label password1;
        private Label username1;
        private Label Signup;
        private Button btnSignup;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblCheck;
    }
}