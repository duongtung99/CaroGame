using System;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Media;

namespace CaroGame
{
    public partial class FormCaro : Form
    {
        SoundPlayer soundlogin = new SoundPlayer(Properties.Resources.NhacNen);
        public FormCaro()
        {
            InitializeComponent();
            //mở trang home
            this.Size = new Size(340, 280);
            Client.InitClient();
            soundlogin.Play();
        }

        private void FormControl1_Load(object sender, EventArgs e)
        {
            
            txtChecklog.Visible = false;
            progressBar1.Visible = false;
        }

        //tạo map
        private void btntao_Click(object sender, EventArgs e)
        {
            Client.host_id = Client.user_id;
            Client.CreateRoom(Client.user_id);
            Thread.Sleep(200);
            if (Client.checkCreateRoom)
            {
                Controls.Remove(FormControl1);
                FormControl1.Visible = false;
                var panel1 = new Map();
                panel1.Size = FormControl1.Size;
                panel1.Location = FormControl1.Location;
                Controls.Add(panel1);
                FormControl1 = panel1;
            }
            
            //ẩn ko liên quan
            btnTao.Visible = false;
            btnVao.Visible = false;
            txtSophong.Visible = false;
        }

        private void btnVao_Click(object sender, EventArgs e)
        {
            Client.join_id = Client.user_id;
            string room_no = txtSophong.Text;
            Client.JoinRoom(Client.user_id, room_no);
            Thread.Sleep(1000);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void txt_Log1_Enter(object sender, EventArgs e)
        {
            txtChecklog.Text = "";
        }

        private void txt_Log2_Enter(object sender, EventArgs e)
        {
            txtChecklog.Text = "";
        }

        //tạo thanh processbar để load form
        private void timer1_Tick(object sender, EventArgs e)
        {
            Client.user_id = txt_Log1.Text;
            string user_pass = txt_Log2.Text;
            Client.Login(Client.user_id, user_pass);
            Thread.Sleep(1000);

            if (Client.checkLogin)
            {
                soundlogin.Stop();
                //không cho hành động khi load form 
                progressBar1.Visible = true;
                txtChecklog.Enabled = false;
                txt_Log1.Enabled = false;
                txt_Log2.Enabled = false;
                linkSignup.Enabled = false;
                btnLogin.Enabled = false;
                progressBar1.Value = progressBar1.Value + 20;
                if(progressBar1.Value > 99)
                {
                    timer1.Enabled = false;
                    txtSophong.Visible = true;
                    panelLogin.Visible = false;
                    Controls.Remove(FormControl1);
                    FormControl1.Visible = false;
                    this.Size = new Size(1169, 760);
                    var panel1 = new Profile1();
                    panel1.Size = FormControl1.Size;
                    panel1.Location = FormControl1.Location;
                    Controls.Add(panel1);
                    FormControl1 = panel1;
                }
            }
            else
            {
                txtChecklog.Text = "*Sai user/password";
            }
        }
    }
}
