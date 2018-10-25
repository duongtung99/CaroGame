using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CaroGame
{
    class Client
    {
        // khai báo thông tin server
        private static string serverIp = "159.89.193.234";
        private static int serverPort = 12345;

        // khai báo thông tin client
        private static int clientPort = 22223;

        // kiểm tra login
        public static bool checkLogin = false;
        
        // khai báo kết nối
        private static UdpClient sendingClient = null;
        private static UdpClient receivingClient = null;

        // khai báo worker
        public static BackgroundWorker workerListener = null;

        public static void InitClient()
        {
            //tạo kết nối đến server
            sendingClient = new UdpClient(serverIp, serverPort);

            // tạo listener lắng nghe response từ server
            receivingClient = new UdpClient(clientPort);

            // cho phép cancel worker
            workerListener = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };

            // thêm công việc cho worker
            workerListener.DoWork += DoReceiver;
        }

        public static void Login(string user_id, string user_pass)
        {
            string message = "login:" + user_id + ":" + user_pass;
            SendData(message);
        }

        public static void Register(string user_id, string user_pass)
        {
            string message = "register:" + user_id + ":" + user_pass;
            SendData(message);
        }

        public static void Play(string session, string user_id, int x, int y)
        {
            string message = "play:" + session + ":" + user_id + ":" + x + ":" + y;
            SendData(message);
        }

        private static void SendData(string message)
        {
            // gửi api lên server
            byte[] messageEncode = Encoding.ASCII.GetBytes(message);
            sendingClient.Send(messageEncode, messageEncode.Length);
        }

        private static void DoReceiver(object sender, DoWorkEventArgs e)
        {
            // tạo endpoint(điểm cuối giao tiếp) gồm ip và port của server
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

            while (true)
            {
                // cancel worker nếu có tín hiệu cancel gửi đến
                if (workerListener.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                // xử lý data nhận được từ server
                byte[] data = receivingClient.Receive(ref endPoint);
                string response = Encoding.ASCII.GetString(data);
                string[] rp = response.Split(':');


                /// <summary>
                /// play:user_session:user_id:x:y
                /// 
                /// login:user_id:user_pass
                /// register:user_id:user_pass
                /// </summary>
                switch (rp[0])
                {
                    case "play":

                        break;
                    case "login":
                        if (rp[1].Equals("true")) {
                            checkLogin = true;
                        }
                        break;
                    case "register":

                        break;
                }


            }
        }
    }
}
