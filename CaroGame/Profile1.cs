using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace CaroGame
{
    public partial class Profile1 : UserControl
    {
        Map map = new Map();
        public Profile1()
        {
            InitializeComponent();
        }

        // Hàm tạo và lấy friend list
        //private async void btnGetFriendlist_Click(object sender, EventArgs e)
        //{

        //    await Task.Run(() =>
        //    {
        //        CaroAPI.FriendList().GetAwaiter().GetResult();
        //    });
        //    foreach (FriendList manh in CaroAPI.getFriendList.data)
        //    {
        //        MessageBox.Show(manh.idUser.ToString() + " " + manh.name + " " + manh.status.ToString());
        //    }
        //}

        private void btnTao_Click(object sender, EventArgs e)
        {
            Client.host_id = Client.user_id;
            Client.CreateRoom(Client.user_id);
            Thread.Sleep(200);
            if (Client.checkCreateRoom)
            {
                //mở map
                panelhome.Visible = false;
                Controls.Add(map);
            }
        }

        private void btnVao_Click(object sender, EventArgs e)
        {
            Client.join_id = Client.user_id;
            Client.room_no = txtSophong.Text;
            Client.JoinRoom(Client.user_id, Client.room_no);
            Thread.Sleep(1000);

            if (Client.checkJoinRoom)
            {
                //mở map
                panelhome.Visible = false;
                Controls.Add(map);
            }

        }
    }
}
