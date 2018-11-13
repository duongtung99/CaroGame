using System;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;

namespace CaroGame
{
    public partial class FormCaro : Form
    {
        //nhạc nền đăng nhập
        SoundPlayer soundlogin = new SoundPlayer(Properties.Resources.NhacNen);
        //khai báo usercontrol
        Map map = new Map();
        Profile1 profile1 = new Profile1();
        Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);

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
            

            Client.InitClient();
            soundlogin.Play();
            panelLogin.BackColor = Color.FromArgb(40, Color.Black);
            panelSignup.BackColor = Color.FromArgb(40, Color.Black);
            txt_Log2.PasswordChar = '*';
        }

        private void FormCaro_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            panelSignup.Visible = false;
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Client.user_id = txt_Log1.Text;
            string user_pass = txt_Log2.Text;
            bool check = await CaroAPI.Login(txt_Log1.Text, txt_Log2.Text);

            if (check)
            {
                //check login và chạy hàm load
                processbartime.Enabled = true;
                Client.UserOnline(Client.user_id);
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void processbar_Tick(object sender, EventArgs e)
        {
             soundlogin.Stop();
             //không cho hành động khi load form 
             progressBar1.Visible = true;
             progressBar1.Value = progressBar1.Value + 50;
             if (progressBar1.Value >= 999)
             {
                //dừng thanh load
                processbartime.Enabled = false;
                //không cho hành động khi load form
                txt_Log1.Enabled = false;
                txt_Log2.Enabled = false;
                btnLogin.Enabled = false;
                panelLogin.Visible = false;
                //mở trang home
                progressBar1.Visible = false;
                Controls.Add(profile1);
             }
           
        }
        //mở form đăng ký
        private void txtSignup_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
        }

        private void FormCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Client.client.Close();
            Client.UserOffline(Client.user_id);
        }
        

        //Form đăng ký
        private void txtSignin_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = false;
        }
       

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text == "")
            {
                MessageBox.Show("Chưa có full name");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Chưa có username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Chưa có password");
            }
            else if (txtPassword.Text != password2.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
            }
            else if(!reg.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Email chưa đúng định dạng");
            }
            else
            {
                bool check = await CaroAPI.SignUp(txtUsername.Text, txtFullname.Text, txtPassword.Text, textBox1.Text);
                if (check)
                {
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("username hoặc email đã tồn tại");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Log1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
