using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Client.user_id = txt_Log1.Text;
            string user_pass = txt_Log2.Text;
            Client.Login(Client.user_id, user_pass);
            Thread.Sleep(100);
            if (Client.checkLogin)
            {
                
            }
            else
            {
                label6.Text = "Sai user/password";
            }
        }

        // form Home đóng sẽ mở lại form Login
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }



        private void linkSignup(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //panel2.Visible = false;
            //btnSignup.Visible = true;
            //linkLabel2.Visible = true;
        }


        private void linkSignin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //panel2.Visible = true;
            //linkLabel2.Visible = false;
        }

        private void txt_Log1_Enter(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void txt_Log2_Enter(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_Log1_Enter_1(object sender, EventArgs e)
        {
            label6.Text = "";
        }

        private void txt_Log2_Enter_1(object sender, EventArgs e)
        {
            label6.Text = "";
        }
    }
}
