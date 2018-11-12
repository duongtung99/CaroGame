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

            txt_Log2.PasswordChar = '*';
        }

        private void FormCaro_Load(object sender, EventArgs e)
        {
            txtChecklog.Visible = false;
            progressBar1.Visible = false;
            panelSignup.Visible = false;
            lblCheck.Visible = false;
        }

        //Form đăng nhập
        
        private void txt_Log1_Enter(object sender, EventArgs e)
        {
            txtChecklog.Text = "";
        }

        private void txt_Log2_Enter(object sender, EventArgs e)
        {
            txtChecklog.Text = "";
        }

        private void opacityform_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.05;
            if (this.Opacity == 1)
            {
                opacityform.Stop();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            processbartime.Enabled = true;
            progressBar1.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                txt_Log1.Enabled = false;
                txt_Log2.Enabled = false;
                btnLogin.Enabled = false;
                progressBar1.Value = progressBar1.Value + 50;
                if (progressBar1.Value == 100)
                {
                    processbartime.Enabled = false;
                    panelLogin.Visible = false;
                    Controls.Add(profile1);
                    progressBar1.Visible = false;
                }
            }
            else
            {
                txtChecklog.Visible = true;
                txtChecklog.Text = "*Sai user/password";
            }
        }

        private void txtSignup_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
        }

        private void FormCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Client.client.Close();
        }
        

        //Form đăng ký
        private void txtSignin_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = false;
        }

        //check nhập email
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0 && txtEmail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    lblCheck.Visible = true;
                    lblCheck.Text = "*Sai định dạng Email";
                }
                else
                {
                    lblCheck.Text = "";
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text != "") Clipboard.SetText(txtFullname.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Log1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
