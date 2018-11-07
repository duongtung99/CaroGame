using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CaroGame
{
    public partial class Map : UserControl
    {
        private static BanCo bc;
        public static Graphics grs;

        // xac dinh so dong so cot
        private int soDong = 30;
        private int soCot = 30;

        // player turn
        public static int turn = 0;
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


            timer1.Start();
            button1.Text = "Start";

            da = DateTime.Now;
            timer1.Start();
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
            if (turn % 2 == 0) //if turn is even
            {
                // hiển thị nước đánh
                Point point = e.Location;
                int vi_tri = BanCo.DanhCo(point.X, point.Y, 1, grs);

                // kiểm tra win
                if (vi_tri != 0)
                {
                    // gửi thông tin cho người chơi còn lại biết mày vừa đánh ở đâu
                    //LAN.SendData("set:play:" + FormLogin.player + ":" + point.X + ":" + point.Y);

                    bool win = BanCo.CheckWin(1, vi_tri);
                    KeHuyDiet.Add(vi_tri);
                    turn++;

                    if (win)
                    {
                        // gửi cho thằng chơi cùng biết mày là người chiến thắng
                        //LAN.SendData("set:win:" + FormLogin.player);

                        // hiển thị nếu mày là người chiến thắng
                        soundwin.Play();
                        timer1.Stop();
                        // tạo game mới
                        //caro.NewGame(grs);
                        //caro.vebanco(grs);
                        //caro.check(soDong, soCot);
                    }
                }
            }
            else if (turn % 2 != 0)
            {
                Point point = e.Location;
                int vi_tri = BanCo.DanhCo(point.X, point.Y, 2, grs);

                if (vi_tri != 0)
                {
                    //LAN.SendData("set:play:" + FormLogin.player + ":" + point.X + ":" + point.Y);

                    bool win = BanCo.CheckWin(2, vi_tri);
                    KeHuyDiet.Add(vi_tri);
                    turn++;

                    if (win)
                    {
                        // gửi cho thằng chơi cùng biết mày là người chiến thắng
                        //LAN.SendData("set:win:" + FormLogin.player);

                        // hiển thị nếu mày là người chiến thắng
                        //MessageBox.Show("Player " + 2 + " won");
                        soundwin.Play();
                        timer1.Stop();
                        //caro.NewGame(grs);
                        //caro.vebanco(grs);
                        //caro.check(soDong, soCot);
                    }
                }
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            lblSophong.Text = Client.room_no;
            lblHost.Text = Client.host_id;
            lblJoin.Text = Client.join_id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now.Subtract(da);
            Time.Text = span.Minutes.ToString() + " : " + span.Seconds.ToString();
        }
    }
}
