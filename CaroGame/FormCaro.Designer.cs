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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.txtChecklog = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txt_Log2 = new System.Windows.Forms.TextBox();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.txt_Log1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.opacityform = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // processbartime
            // 
            this.processbartime.Tick += new System.EventHandler(this.processbar_Tick);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.formName);
            this.panelLogin.Controls.Add(this.txtChecklog);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txt_Log2);
            this.panelLogin.Controls.Add(this.linkSignup);
            this.panelLogin.Controls.Add(this.txt_Log1);
            this.panelLogin.Location = new System.Drawing.Point(329, 211);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(493, 275);
            this.panelLogin.TabIndex = 13;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.Color.Transparent;
            this.formName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.Color.Red;
            this.formName.Location = new System.Drawing.Point(179, 16);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(91, 33);
            this.formName.TabIndex = 32;
            this.formName.Text = "Login";
            // 
            // txtChecklog
            // 
            this.txtChecklog.AutoSize = true;
            this.txtChecklog.BackColor = System.Drawing.Color.Transparent;
            this.txtChecklog.ForeColor = System.Drawing.Color.Red;
            this.txtChecklog.Location = new System.Drawing.Point(262, 151);
            this.txtChecklog.Name = "txtChecklog";
            this.txtChecklog.Size = new System.Drawing.Size(23, 13);
            this.txtChecklog.TabIndex = 30;
            this.txtChecklog.Text = "null";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Brown;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(119, 180);
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
            this.txt_Log2.Location = new System.Drawing.Point(110, 111);
            this.txt_Log2.Name = "txt_Log2";
            this.txt_Log2.Size = new System.Drawing.Size(237, 26);
            this.txt_Log2.TabIndex = 2;
            this.txt_Log2.Enter += new System.EventHandler(this.txt_Log2_Enter);
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.BackColor = System.Drawing.Color.Transparent;
            this.linkSignup.LinkColor = System.Drawing.Color.Yellow;
            this.linkSignup.Location = new System.Drawing.Point(304, 212);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(43, 13);
            this.linkSignup.TabIndex = 4;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Sign up";
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_Log1
            // 
            this.txt_Log1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Log1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log1.Location = new System.Drawing.Point(110, 62);
            this.txt_Log1.Name = "txt_Log1";
            this.txt_Log1.Size = new System.Drawing.Size(237, 26);
            this.txt_Log1.TabIndex = 1;
            this.txt_Log1.TextChanged += new System.EventHandler(this.txt_Log1_TextChanged);
            this.txt_Log1.Enter += new System.EventHandler(this.txt_Log1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(50, 544);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1072, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 31;
            // 
            // opacityform
            // 
            this.opacityform.Tick += new System.EventHandler(this.opacityform_Tick);
            // 
            // FormCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaroGame.Properties.Resources.bglogin__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 740);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCaro";
            this.Text = "FormCaro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCaro_FormClosing);
            this.Load += new System.EventHandler(this.FormCaro_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label txtChecklog;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txt_Log2;
        private System.Windows.Forms.LinkLabel linkSignup;
        private System.Windows.Forms.TextBox txt_Log1;
        private System.Windows.Forms.Timer processbartime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Timer opacityform;
    }
}