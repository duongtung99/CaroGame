using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
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
