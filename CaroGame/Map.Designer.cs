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
            this.label2 = new System.Windows.Forms.Label();
            this.Phong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Avt1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Avt2 = new System.Windows.Forms.PictureBox();
            this.Join = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.lblJoin = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblSophong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlChess = new System.Windows.Forms.Panel();
            this.TenPhong = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avt2)).BeginInit();
            this.pnlChess.SuspendLayout();
            this.TenPhong.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 688);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 20);
            this.textBox1.TabIndex = 29;
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(248, 587);
            this.lb1.Name = "lb1";
            this.lb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb1.Size = new System.Drawing.Size(672, 95);
            this.lb1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Phong.Location = new System.Drawing.Point(29, 23);
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
            this.panel2.BackgroundImage = global::CaroGame.Properties.Resources.avata;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Avt1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(6, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 189);
            this.panel2.TabIndex = 33;
            // 
            // Avt1
            // 
            this.Avt1.Image = global::CaroGame.Properties.Resources._37725208_1897723226915374_5593628633076858880_n;
            this.Avt1.Location = new System.Drawing.Point(58, 28);
            this.Avt1.Name = "Avt1";
            this.Avt1.Size = new System.Drawing.Size(111, 133);
            this.Avt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avt1.TabIndex = 0;
            this.Avt1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CaroGame.Properties.Resources.avata;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Avt2);
            this.panel1.Location = new System.Drawing.Point(939, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 189);
            this.panel1.TabIndex = 30;
            // 
            // Avt2
            // 
            this.Avt2.Image = ((System.Drawing.Image)(resources.GetObject("Avt2.Image")));
            this.Avt2.Location = new System.Drawing.Point(57, 28);
            this.Avt2.Name = "Avt2";
            this.Avt2.Size = new System.Drawing.Size(118, 133);
            this.Avt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avt2.TabIndex = 0;
            this.Avt2.TabStop = false;
            // 
            // Join
            // 
            this.Join.AutoSize = true;
            this.Join.BackColor = System.Drawing.Color.Transparent;
            this.Join.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Join.ForeColor = System.Drawing.Color.Maroon;
            this.Join.Location = new System.Drawing.Point(985, 626);
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
            this.Host.Location = new System.Drawing.Point(982, 571);
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
            this.lblJoin.Location = new System.Drawing.Point(1070, 626);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(24, 25);
            this.lblJoin.TabIndex = 37;
            this.lblJoin.Text = "1";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(1057, 580);
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
            this.lblSophong.Location = new System.Drawing.Point(137, 23);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(60, 25);
            this.lblSophong.TabIndex = 39;
            this.lblSophong.Text = "3567";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label1";
            // 
            // pnlChess
            // 
            this.pnlChess.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlChess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChess.Controls.Add(this.label7);
            this.pnlChess.Location = new System.Drawing.Point(248, 54);
            this.pnlChess.Name = "pnlChess";
            this.pnlChess.Size = new System.Drawing.Size(672, 528);
            this.pnlChess.TabIndex = 27;
            this.pnlChess.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChess_Paint);
            this.pnlChess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChess_MouseClick);
            // 
            // TenPhong
            // 
            this.TenPhong.BackColor = System.Drawing.Color.Transparent;
            this.TenPhong.BackgroundImage = global::CaroGame.Properties.Resources.room;
            this.TenPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TenPhong.Controls.Add(this.Phong);
            this.TenPhong.Controls.Add(this.lblSophong);
            this.TenPhong.Location = new System.Drawing.Point(6, 3);
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Size = new System.Drawing.Size(236, 69);
            this.TenPhong.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::CaroGame.Properties.Resources.level;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 109);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::CaroGame.Properties.Resources.level__2_;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(950, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 109);
            this.panel4.TabIndex = 41;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaroGame.Properties.Resources.bgmap;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TenPhong);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblJoin);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlChess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(1170, 734);
            this.Load += new System.EventHandler(this.Map_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avt1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avt2)).EndInit();
            this.pnlChess.ResumeLayout(false);
            this.pnlChess.PerformLayout();
            this.TenPhong.ResumeLayout(false);
            this.TenPhong.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Phong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Avt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Avt2;
        private System.Windows.Forms.Label Join;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlChess;
        private System.Windows.Forms.Panel TenPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
