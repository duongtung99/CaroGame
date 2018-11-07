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
            this.FormControl1 = new System.Windows.Forms.UserControl();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogin = new System.Windows.Forms.Panel();
            this.formName = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtChecklog = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txt_Log2 = new System.Windows.Forms.TextBox();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.txt_Log1 = new System.Windows.Forms.TextBox();
            this.btnVao = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormControl1
            // 
            this.FormControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FormControl1.Location = new System.Drawing.Point(-6, -2);
            this.FormControl1.MaximumSize = new System.Drawing.Size(1169, 740);
            this.FormControl1.Name = "FormControl1";
            this.FormControl1.Size = new System.Drawing.Size(1169, 740);
            this.FormControl1.TabIndex = 9;
            this.FormControl1.Load += new System.EventHandler(this.FormControl1_Load);
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(294, 39);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(177, 20);
            this.txtSophong.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImage = global::CaroGame.Properties.Resources.bglogin__2_;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.formName);
            this.panelLogin.Controls.Add(this.progressBar1);
            this.panelLogin.Controls.Add(this.txtChecklog);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txt_Log2);
            this.panelLogin.Controls.Add(this.linkSignup);
            this.panelLogin.Controls.Add(this.txt_Log1);
            this.panelLogin.Location = new System.Drawing.Point(-6, -2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(339, 261);
            this.panelLogin.TabIndex = 13;
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.BackColor = System.Drawing.Color.Transparent;
            this.formName.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formName.ForeColor = System.Drawing.Color.Red;
            this.formName.Location = new System.Drawing.Point(125, 11);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(82, 33);
            this.formName.TabIndex = 32;
            this.formName.Text = "Login";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(3, 149);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(336, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // txtChecklog
            // 
            this.txtChecklog.AutoSize = true;
            this.txtChecklog.BackColor = System.Drawing.Color.Transparent;
            this.txtChecklog.ForeColor = System.Drawing.Color.Red;
            this.txtChecklog.Location = new System.Drawing.Point(143, 149);
            this.txtChecklog.Name = "txtChecklog";
            this.txtChecklog.Size = new System.Drawing.Size(23, 13);
            this.txtChecklog.TabIndex = 30;
            this.txtChecklog.Text = "null";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Brown;
            this.btnLogin.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 45);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_Log2
            // 
            this.txt_Log2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Log2.Location = new System.Drawing.Point(65, 113);
            this.txt_Log2.Name = "txt_Log2";
            this.txt_Log2.Size = new System.Drawing.Size(211, 20);
            this.txt_Log2.TabIndex = 27;
            this.txt_Log2.Enter += new System.EventHandler(this.txt_Log2_Enter);
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.BackColor = System.Drawing.Color.Transparent;
            this.linkSignup.LinkColor = System.Drawing.Color.Yellow;
            this.linkSignup.Location = new System.Drawing.Point(212, 212);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(43, 13);
            this.linkSignup.TabIndex = 29;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Sign up";
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_Log1
            // 
            this.txt_Log1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Log1.Location = new System.Drawing.Point(65, 76);
            this.txt_Log1.Name = "txt_Log1";
            this.txt_Log1.Size = new System.Drawing.Size(211, 20);
            this.txt_Log1.TabIndex = 26;
            this.txt_Log1.Enter += new System.EventHandler(this.txt_Log1_Enter);
            // 
            // btnVao
            // 
            this.btnVao.BackColor = System.Drawing.Color.Brown;
            this.btnVao.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVao.ForeColor = System.Drawing.Color.White;
            this.btnVao.Location = new System.Drawing.Point(155, 29);
            this.btnVao.Name = "btnVao";
            this.btnVao.Size = new System.Drawing.Size(133, 39);
            this.btnVao.TabIndex = 11;
            this.btnVao.Text = "Vào phòng";
            this.btnVao.UseVisualStyleBackColor = false;
            this.btnVao.Click += new System.EventHandler(this.btnVao_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Brown;
            this.btnTao.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(12, 29);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(125, 39);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Tạo phòng";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // FormCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 740);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.txtSophong);
            this.Controls.Add(this.btnVao);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.FormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCaro";
            this.Text = "FormCaro";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.UserControl FormControl1;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Button btnVao;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label txtChecklog;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txt_Log2;
        private System.Windows.Forms.LinkLabel linkSignup;
        private System.Windows.Forms.TextBox txt_Log1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label formName;
    }
}