using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroGame
{
    class Client
    {
        // khai báo thông tin server
        //debug
        //private static string serverIp = "127.0.0.1";
        // real server
        private static string serverIp = "159.89.193.234";
        private static int serverPort = 12345;

        // tạo endpoint(điểm cuối giao tiếp) gồm ip và port của server
        private static IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

        // kiểm tra
        public static bool checkLogin = false;
        public static bool checkRegister = false;
        public static bool checkCreateRoom = false;


        // thông tin user
        public static string user_id;
        public static string host_id;
        public static string join_id;
        public static string room_no;
        //public static string user_session = "";

        // khai báo kết nối
        private static UdpClient client = null;
        //private static IPEndPoint serverEP = null;

        // khai báo worker
        public static BackgroundWorker workerListener = null;

        public static void InitClient()
        {
            // tạo udpclient lắng nghe port 12121
            client = new UdpClient(12121);

            // cho phép cancel worker
            workerListener = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };

            // thêm công việc cho worker
            workerListener.DoWork += DoReceiver;

            // start worker
            workerListener.RunWorkerAsync();
        }

        public static void Login(string user_id, string user_pass)
        {
            string message = "login:" + user_id + ":" + user_pass;
            try
            {
                SendData(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant connect to server");
            }

        }

        public static void Register(string user_id, string user_pass)
        {
            string message = "register:" + user_id + ":" + user_pass;
            SendData(message);
        }

        public static void Play(string user_session, string user_id, int x, int y)
        {
            string message = "play:" + user_session + ":" + user_id + ":" + x + ":" + y;
            SendData(message);
        }

        public static void CreateRoom(string user_id)
        {
            Random random = new Random();
            room_no = Convert.ToString(random.Next(1, 10000));
            string message = "create:" + user_id + ":" + room_no;
            SendData(message);
        }

        public static void JoinRoom(string user_id, string room_no)
        {
            string message = "join:" + user_id + ":" + room_no;
            SendData(message);
        }

        private static void SendData(string message)
        {
            // gửi api lên server
            byte[] messageEncode = Encoding.ASCII.GetBytes(message);
            //try
            //{
            client.Send(messageEncode, messageEncode.Length, serverEP);
            //} catch (Exception ex)
            //{
            //    MessageBox.Show("cant connect to server");
            //}
        }

        private static void DoReceiver(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // cancel worker nếu có tín hiệu cancel gửi đến
                if (workerListener.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // xử lý data nhận được từ server
                byte[] data = client.Receive(ref serverEP);
                string response = Encoding.ASCII.GetString(data);
                string[] rp = response.Split(':');

                /// <summary>
                /// play:user_session:user_id:x:y
                /// login:user_id:user_pass
                /// register:user_id:user_pass
                /// </summary>
                switch (rp[0])
                {
                    case "play":

                        break;
                    case "login":
                        if (rp[1].Equals("true"))
                        {
                            checkLogin = true;
                        }
                        break;
                    case "register":
                        if (rp[1].Equals("true"))
                        {
                            checkRegister = true;
                        }
                        break;
                    case "create":
                        if (rp[1].Equals("true"))
                        {
                            checkCreateRoom = true;
                        }
                        break;
                    case "join":
                        if (rp[1].Equals("true"))
                        {
                            host_id = rp[2];
                        }
                        else
                        {
                            MessageBox.Show("Phòng không tồn tại");
                        }
                        break;
                    case "host":
                        if (rp[1].Equals(user_id))
                        {
                            join_id = rp[2];
                        }
                        break;
                }


            }
        }
    }
}
