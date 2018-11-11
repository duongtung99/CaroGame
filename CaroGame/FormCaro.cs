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
        //nhạc nền đăng nhập
        SoundPlayer soundlogin = new SoundPlayer(Properties.Resources.NhacNen);
        //khai báo usercontrol
        Map map = new Map();
        Profile1 profile1 = new Profile1();

        #region force dublebuffer (giảm chớp nháy khi load ảnh)
        private const int WS_EX_COMPOSITED = 0x02000000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }
        #endregion


        public FormCaro()
        {
            InitializeComponent();

            // tinh chỉnh để load background không chớp giật
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                              ControlStyles.UserPaint |
                              ControlStyles.OptimizedDoubleBuffer,
                              true);
            //hiệu úng mở bàn cờ
            //this.Opacity = 0;
            //opacityform.Start();

            Client.InitClient();
            soundlogin.Play();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            processbartime.Enabled = true;
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

        private void FormCaro_Load(object sender, EventArgs e)
        {
            txtChecklog.Visible = false;
            progressBar1.Visible = false;
        }

        private void opacityform_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.05;
            if (this.Opacity == 1)
            {
                opacityform.Stop();
            }
        }

        private void processbar_Tick(object sender, EventArgs e)
        {
            Client.user_id = txt_Log1.Text;
            string user_pass = txt_Log2.Text;
            CaroAPI.Login(txt_Log1.Text, txt_Log2.Text);

            if (CaroAPI.user != null)
            {
                soundlogin.Stop();
                //không cho hành động khi load form 
                progressBar1.Visible = true;
                txtChecklog.Enabled = false;
                txt_Log1.Enabled = false;
                txt_Log2.Enabled = false;
                linkSignup.Enabled = false;
                btnLogin.Enabled = false;
                progressBar1.Value = progressBar1.Value + 50;
                if (progressBar1.Value == 100)
                {
                    processbartime.Enabled = false;
                    panelLogin.Visible = false;
                    Controls.Add(profile1);
                }
            }
            else
            {
                txtChecklog.Text = "*Sai user/password";
            }
        }


        //private void FormCaro_Load(object sender, EventArgs e)
        //{
        //    txtChecklog.Visible = false;
        //    progressBar1.Visible = false;
        //}

        //private void opacityform_Tick(object sender, EventArgs e)
        //{
        //    this.Opacity = this.Opacity + 0.05;
        //    if (this.Opacity == 1)
        //    {
        //        opacityform.Stop();
        //    }
        //}

        private void FormCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Client.client.Close();
        }

        private void txt_Log1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
