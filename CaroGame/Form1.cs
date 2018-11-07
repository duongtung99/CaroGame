using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CaroGame
{
    public partial class Form1 : Form
    {
        private static BanCo bc;
        public static Graphics grs;

        // xac dinh so dong so cot
        private int soDong = 30;
        private int soCot = 30;

        // player turn
        public static int turn = -1;
        public static int player_turn = 0;
        public List<int> KeHuyDiet = new List<int>();

        //nhacnen
        SoundPlayer sound = new SoundPlayer(Properties.Resources.NhacNen);
        SoundPlayer soundwin = new SoundPlayer(Properties.Resources.WinSound);
        SoundPlayer soundlose = new SoundPlayer(Properties.Resources.LoseSound);
        public Form1()
        {
            InitializeComponent();
            //hiệu úng mở bàn cờ
            //this.Opacity = 0;
            //timer1.Start();
            //vẽ bàn cờ
            bc = new BanCo(soDong, soCot);
            grs = pnlChess.CreateGraphics();
<<<<<<< HEAD
            label5.Text = Client.user_id;
=======

            //
            Client.host_label = label5;
            Client.join_label = label6;
            Client.waiting_label = label7;
>>>>>>> 2deabcceacb1e40db089c3ed199b6b750bb3536d
        }

        private void pnlChess_Paint(object sender, PaintEventArgs e)
        {
           bc.VeBanCo(grs);
            // gán số 1 cho tất cả các ô khi bắt đầu game
            bc.check(soDong, soCot);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity +0.05;
            if (this.Opacity == 1 )
            {
                timer1.Stop();
            }

        }

        private void pnlChess_MouseClick(object sender, MouseEventArgs e)
        {
            // Debug
            if ((turn % 2 == 0) && (player_turn == 1)) //if turn is even
            {
                // hiển thị nước đánh
                Point point = e.Location;
                int vi_tri = BanCo.DanhCo(point.X, point.Y, player_turn, grs);

                // kiểm tra win
                if (vi_tri != 0)
                {
                    // gửi thông tin cho người chơi còn lại biết mày vừa đánh ở đâu
                    Client.Play(Client.user_id, Client.room_no, point.X, point.Y);

                    bool win = BanCo.CheckWin(player_turn, vi_tri);
                    KeHuyDiet.Add(vi_tri);
                    turn++;

                    if (win)
                    {
                        // gửi cho thằng chơi cùng biết mày là người chiến thắng
                        //LAN.SendData("set:win:" + FormLogin.player);

                        // hiển thị nếu mày là người chiến thắng
                        soundwin.Play();
                        timer2.Enabled = true;
                        // tạo game mới
                        //caro.NewGame(grs);
                        //caro.vebanco(grs);
                        //caro.check(soDong, soCot);
                    }
                }
            }
            else if ((turn % 2 != 0) && (player_turn == 2))
            {
                Point point = e.Location;
                int vi_tri = BanCo.DanhCo(point.X, point.Y, player_turn, grs);

                if (vi_tri != 0)
                {
                    // gửi thông tin cho người chơi còn lại biết mày vừa đánh ở đâu
                    Client.Play(Client.user_id, Client.room_no, point.X, point.Y);

                    bool win = BanCo.CheckWin(player_turn, vi_tri);
                    KeHuyDiet.Add(vi_tri);
                    turn++;

                    if (win)
                    {
                        // gửi cho thằng chơi cùng biết mày là người chiến thắng
                        //LAN.SendData("set:win:" + FormLogin.player);

                        // hiển thị nếu mày là người chiến thắng
                        //MessageBox.Show("Player " + 2 + " won");
                        soundwin.Play();
                        panel1.Enabled = false;
                        timer2.Enabled = true;
                        //caro.NewGame(grs);
                        //caro.vebanco(grs);
                        //caro.check(soDong, soCot);
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            grs.DrawImage(Properties.Resources.Logo_You_Win, 200, 200, 400, 120);
            grs.DrawString("Nhấn Enter để tiếp tục", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.White), 200, 200);
        }

<<<<<<< HEAD
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
              
        }

=======
>>>>>>> 2deabcceacb1e40db089c3ed199b6b750bb3536d
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Client.room_no;
            label5.Text = Client.host_id;
            label6.Text = Client.join_id;

            if (Client.host_id.Equals(Client.user_id))
            {
                label7.Text = "Chờ người chơi...";
                Client.workerWaitForPlayer.RunWorkerAsync();
            }

            Client.workerChangeTurn.RunWorkerAsync();
        }

<<<<<<< HEAD
        
=======
>>>>>>> 2deabcceacb1e40db089c3ed199b6b750bb3536d
    }
}
