﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace CaroGame
{
    public partial class Map : UserControl
    {
        private static BanCo bc;
        public static Graphics grs;

        // xac dinh so dong so cot
        private int soDong = 28;
        private int soCot = 22;

        // player turn
        public static int turn = -1;
        public static int player_turn = 0;
        public List<int> KeHuyDiet = new List<int>();

        //nhacnen
        SoundPlayer soundwin = new SoundPlayer(Properties.Resources.WinSound);
        SoundPlayer soundlose = new SoundPlayer(Properties.Resources.LoseSound);
        //dem gio
        DateTime da;

        public Map()
        {
            InitializeComponent();
            bc = new BanCo(soDong, soCot);
            grs = pnlChess.CreateGraphics();
            
            button1.Text = "Start";
            //đếm giờ
            da = DateTime.Now;

            Client.host_label = lblHost;
            Client.join_label = lblJoin;
            Client.waiting_label = label7;
        }

        private void pnlChess_Paint(object sender, PaintEventArgs e)
        {
            bc.VeBanCo(grs);
            // gán số 1 cho tất cả các ô khi bắt đầu game
            bc.check(soDong, soCot);
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
                        // hiển thị nếu mày là người chiến thắng
                        soundwin.Play();
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
                        // hiển thị nếu mày là người chiến thắng
                        soundwin.Play();
                        panel1.Enabled = false;
                        MessageBox.Show("wwin");
                    }
                }
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            lblSophong.Text = Client.room_no;
            lblHost.Text = Client.host_id;
            lblJoin.Text = Client.join_id;

            if (Client.host_id.Equals(Client.user_id))
            {
                label7.Text = "Chờ người chơi...";
                Client.workerWaitForPlayer.RunWorkerAsync();
                //pnlChess.Enabled = false;
            }

            Client.workerChangeTurn.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now.Subtract(da);
            Time.Text = span.Minutes.ToString() + " : " + span.Seconds.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            grs.DrawImage(Properties.Resources.phaohoa, 200, 200, 400, 120);
            //grs.DrawString("Nhấn Enter để tiếp tục", new Font("Arial", 16, FontStyle.Bold), new SolidBrush(Color.White), 200, 200);
        }
    }
}
