using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class LoginCaro : Form
    {
        bool Hided;
        public LoginCaro()
        {
            InitializeComponent();
            Hided = false;
            txt3.PasswordChar = 'd';
            txt_Log2.PasswordChar = '*';

            Client.InitClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_id = txt_Log1.Text;
            string user_pass = txt_Log2.Text;
            Client.Login(user_id, user_pass);
            Thread.Sleep(100);
            if (Client.checkLogin)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
        }
     

        private void linkSignup(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
            btnSignup.Visible = true;
            linkLabel2.Visible = true;
        }

        private void linkSignin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
            linkLabel2.Visible = false;
        }

        
    }
}
