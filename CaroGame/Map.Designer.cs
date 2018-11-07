namespace CaroGame
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlChess = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Phong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Join = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblSophong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlChess.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 691);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 20);
            this.textBox1.TabIndex = 29;
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(220, 632);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(724, 56);
            this.lb1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlChess
            // 
            this.pnlChess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlChess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChess.Controls.Add(this.label7);
            this.pnlChess.Location = new System.Drawing.Point(220, 56);
            this.pnlChess.Name = "pnlChess";
            this.pnlChess.Size = new System.Drawing.Size(724, 570);
            this.pnlChess.TabIndex = 27;
            this.pnlChess.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChess_Paint);
            this.pnlChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChess_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(113, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 32;
            // 
            // Phong
            // 
            this.Phong.AutoSize = true;
            this.Phong.BackColor = System.Drawing.Color.Transparent;
            this.Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phong.ForeColor = System.Drawing.Color.Maroon;
            this.Phong.Location = new System.Drawing.Point(20, 542);
            this.Phong.Name = "Phong";
            this.Phong.Size = new System.Drawing.Size(93, 25);
            this.Phong.TabIndex = 31;
            this.Phong.Text = "Phòng  :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Red;
            this.Time.Location = new System.Drawing.Point(521, 19);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(83, 32);
            this.Time.TabIndex = 34;
            this.Time.Text = "0 :  0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CaroGame.Properties.Resources.khung1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 297);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaroGame.Properties.Resources._37725208_1897723226915374_5593628633076858880_n;
            this.pictureBox1.Location = new System.Drawing.Point(15, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CaroGame.Properties.Resources.khung1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(960, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 297);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Join
            // 
            this.Join.AutoSize = true;
            this.Join.BackColor = System.Drawing.Color.Transparent;
            this.Join.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Join.ForeColor = System.Drawing.Color.Maroon;
            this.Join.Location = new System.Drawing.Point(967, 433);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(66, 25);
            this.Join.TabIndex = 36;
            this.Join.Text = "Join :";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.BackColor = System.Drawing.Color.Transparent;
            this.Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host.ForeColor = System.Drawing.Color.Maroon;
            this.Host.Location = new System.Drawing.Point(964, 378);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(69, 25);
            this.Host.TabIndex = 35;
            this.Host.Text = "Host :";
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoin.ForeColor = System.Drawing.Color.Maroon;
            this.lblJoin.Location = new System.Drawing.Point(1052, 433);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(24, 25);
            this.lblJoin.TabIndex = 37;
            this.lblJoin.Text = "1";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(1039, 387);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(35, 13);
            this.lblHost.TabIndex = 38;
            this.lblHost.Text = "label5";
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.BackColor = System.Drawing.Color.Transparent;
            this.lblSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblSophong.ForeColor = System.Drawing.Color.Maroon;
            this.lblSophong.Location = new System.Drawing.Point(113, 542);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(24, 25);
            this.lblSophong.TabIndex = 39;
            this.lblSophong.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaroGame.Properties.Resources.bgmap;
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblJoin);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlChess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phong);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(1170, 734);
            this.Load += new System.EventHandler(this.Map_Load);
            this.pnlChess.ResumeLayout(false);
            this.pnlChess.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlChess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Phong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Join;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label label7;
    }
}
