using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openfile.InitialDirectory = @"c:\Program Files";
            openfile.Filter = "All files (*.*)|*.*|exe files (*.exe)|*.exe";
            openfile.FilterIndex = 1;
            openfile.RestoreDirectory = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openfile.FileName);
            }
        }
    }
}
