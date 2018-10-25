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
    public partial class Form1 : Form
    {
        private static BanCo bc;
        public static Graphics grs;

        // xac dinh so dong so cot
        private int soDong = 30;
        private int soCot = 30;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
            bc = new BanCo(soDong, soCot);
            grs = pnlChess.CreateGraphics();
        }

        private void pnlChess_Paint(object sender, PaintEventArgs e)
        {
           bc.VeBanCo(grs);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity +0.1;
            if (this.Opacity == 1 )
            {
                timer1.Stop();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
