using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CaroGame
{
    public partial class Profile1 : UserControl
    {
        Map map = new Map();
        public Profile1()
        {
            InitializeComponent();
        }
        //Controls.Remove(FormControl1);
        // FormControl1.Visible = false;
        //this.Size = new Size(1169, 760);
        //var panel = new Profile1();
        //panel.Size = FormControl1.Size;
        //            panel.Location = FormControl1.Location;
        //            Controls.Add(panel);
        //            FormControl1 = panel;   
       

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
                btnTao.Visible = false;
                btnVao.Visible = false;
                txtSophong.Visible = false;
                //mở map
                panelhome.Visible = false;
                Controls.Add(map);
            }
            
        }
    }
}
