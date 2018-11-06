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
        private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

        public static void SendData(string message)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, clientEP);
        }

        public static void SendData(string message, IPEndPoint userEP)
        {
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
                        HandleClient.Register(code[1], code[2]);
                        break;
                    case "create":
                        HandleClient.CreateRoom(code[1], code[2], clientEP);
                        break;
                    case "join":
                        HandleClient.JoinRoom(code[1], code[2], clientEP);

                        break;
                }
            }
        }
    }
}
