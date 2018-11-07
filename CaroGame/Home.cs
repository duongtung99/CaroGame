using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CaroGame
{
    public partial class Home : Form
    {
        OpenFileDialog openfile = new OpenFileDialog();
        public Home()
        {
            InitializeComponent();
            Rectangle r = new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pictureBox3.Width - 7, pictureBox3.Height - 3);
            Region rg = new Region(gp);
            pictureBox3.Region = rg;

            //dùng usercontrol
            Controls.Remove(FormControl);
            FormControl.Visible = false;

            var panel1 = new Profile1();
            panel1.Size = FormControl.Size;
            panel1.Location = FormControl.Location;
            Controls.Add(panel1);

            FormControl = panel1;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //FormControl = panel1;
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Remove(FormControl);
            FormControl.Visible = false;
            var panel1 = new Map();
            panel1.Size = FormControl.Size;
            panel1.Location = FormControl.Location;
            Controls.Add(panel1);

            FormControl = panel1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openfile.InitialDirectory = @"C:\Program Files";
            openfile.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openfile.FileName);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            Client.CreateRoom(Client.user_id);
            Thread.Sleep(200);
            if (Client.checkCreateRoom)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }
    }
}
