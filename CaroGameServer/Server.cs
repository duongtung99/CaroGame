using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CaroGameServer
{
    class Server
    {
        // mở port listen
        private const int serverPort = 12345;
        private static UdpClient server = new UdpClient(serverPort);

        // nhận dữ liệu từ tất cả các client
        private const int clientPort = 12121;
        private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, clientPort);

        public static void SendData(string message)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, clientEP);
        }

        public static void SendDataToPlayer(string message, IPAddress user_ip)
        {
            IPEndPoint userEP = new IPEndPoint(user_ip, clientPort);

            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, userEP);
        }

        public static void Listener()
        {
            while (true)
            {
                // xử lý data gửi từ client
                byte[] data = server.Receive(ref clientEP);
                string message = Encoding.ASCII.GetString(data);
                //Console.WriteLine(message);

                string[] code = message.Split(':');

                switch (code[0])
                {
                    case "play":

                        break;
                    case "login":
                        HandleClient.Login(code[1], code[2]);
                        break;
                    case "register":
                        HandleClient.Register(code[1], code[2], code[3]);
                        break;
                    case "create":
                        HandleClient.CreateRoom(code[1], code[2], clientEP.Address);
                        break;
                    case "join":
                        HandleClient.JoinRoom(code[1], code[2], clientEP.Address);

                        break;
                }
            }
        }
    }
}
