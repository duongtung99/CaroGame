namespace CaroGame
{
    partial class Profile1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listfriend = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.danhsachphong = new System.Windows.Forms.DataGridView();
            this.chat = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnVao = new System.Windows.Forms.Button();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.panelhome = new System.Windows.Forms.Panel();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listfriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelhome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.listfriend);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(943, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 734);
            this.panel1.TabIndex = 4;
            // 
            // listfriend
            // 
            this.listfriend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listfriend.Location = new System.Drawing.Point(-3, 136);
            this.listfriend.Name = "listfriend";
            this.listfriend.Size = new System.Drawing.Size(242, 598);
            this.listfriend.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::CaroGame.Properties.Resources._37725208_1897723226915374_5593628633076858880_n;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // danhsachphong
            // 
            this.danhsachphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachphong.Location = new System.Drawing.Point(15, 14);
            this.danhsachphong.Name = "danhsachphong";
            this.danhsachphong.Size = new System.Drawing.Size(922, 429);
            this.danhsachphong.TabIndex = 9;
            // 
            // chat
            // 
            this.chat.FormattingEnabled = true;
            this.chat.Location = new System.Drawing.Point(-1, 490);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(327, 238);
            this.chat.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnTao);
            this.panel2.Controls.Add(this.btnVao);
            this.panel2.Controls.Add(this.txtSophong);
            this.panel2.Location = new System.Drawing.Point(430, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 71);
            this.panel2.TabIndex = 16;
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Brown;
            this.btnTao.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(3, 22);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(125, 39);
            this.btnTao.TabIndex = 10;
            this.btnTao.Text = "Tạo phòng";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnVao
            // 
            this.btnVao.BackColor = System.Drawing.Color.Brown;
            this.btnVao.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVao.ForeColor = System.Drawing.Color.White;
            this.btnVao.Location = new System.Drawing.Point(134, 22);
            this.btnVao.Name = "btnVao";
            this.btnVao.Size = new System.Drawing.Size(133, 39);
            this.btnVao.TabIndex = 11;
            this.btnVao.Text = "Vào phòng";
            this.btnVao.UseVisualStyleBackColor = false;
            this.btnVao.Click += new System.EventHandler(this.btnVao_Click);
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(280, 34);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(177, 20);
            this.txtSophong.TabIndex = 12;
            // 
            // panelhome
            // 
            this.panelhome.BackColor = System.Drawing.Color.Transparent;
            this.panelhome.Controls.Add(this.txtChat);
            this.panelhome.Controls.Add(this.btnChat);
            this.panelhome.Controls.Add(this.danhsachphong);
            this.panelhome.Controls.Add(this.panel2);
            this.panelhome.Controls.Add(this.panel1);
            this.panelhome.Controls.Add(this.chat);
            this.panelhome.Location = new System.Drawing.Point(1, 0);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(1182, 731);
            this.panelhome.TabIndex = 17;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(332, 649);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(100, 20);
            this.txtChat.TabIndex = 18;
            // 
            // btnChat
            // 
            this.btnChat.ForeColor = System.Drawing.Color.Black;
            this.btnChat.Location = new System.Drawing.Point(357, 675);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 23);
            this.btnChat.TabIndex = 17;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // Profile1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaroGame.Properties.Resources.backgroundhome__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelhome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Profile1";
            this.Size = new System.Drawing.Size(1170, 734);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listfriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelhome.ResumeLayout(false);
            this.panelhome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView danhsachphong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView listfriend;
        private System.Windows.Forms.ListBox chat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnVao;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnChat;
    }
}
