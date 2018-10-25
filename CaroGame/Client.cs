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

        // kiểm tra
        public static bool checkLogin = false;
        public static bool checkRegister = false;

        // thông tin user
        public static string user_id = "";
        //public static string user_session = "";
        
        // khai báo kết nối
        private static UdpClient client = null;
        private static IPEndPoint serverEP = null;

        // khai báo worker
        public static BackgroundWorker workerListener = null;

        public static void InitClient()
        {
            // tạo udpclient
            client = new UdpClient();

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

        public static void Play(string user_session, string user_id, int x, int y)
        {
            string message = "play:" + user_session + ":" + user_id + ":" + x + ":" + y;
            SendData(message);
        }

        private static void SendData(string message)
        {
            // gửi api lên server
            byte[] messageEncode = Encoding.ASCII.GetBytes(message);
            client.Send(messageEncode, messageEncode.Length, serverEP);
        }

        private static void DoReceiver(object sender, DoWorkEventArgs e)
        {
            // tạo endpoint(điểm cuối giao tiếp) gồm ip và port của server
            serverEP = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

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
                        if (rp[1].Equals("true")) {
                            checkLogin = true;
                        }
                        break;
                    case "register":
                        if (rp[1].Equals("true"))
                        {
                            checkRegister = true;
                        }
                        break;
                }


            }
        }
    }
}
