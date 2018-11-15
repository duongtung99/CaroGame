using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace CaroGameServer
{
    class Server
    {
        // mở port listen
        private const int serverPort = 12345;
        //private static UdpClient server = new UdpClient(serverPort);
        private static TcpListener server = new TcpListener(IPAddress.Any, serverPort);

        // nhận dữ liệu từ tất cả các client
        //private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
        private static TcpClient client = null;

        private static string data;

        public static void SendData(string message, TcpClient client)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            //stream.Close();
        }


        public static void Listener()
        {
            int counter = 0;
            Server sv = new Server();

            server.Start();

            while (true)
            {
                counter++;

                // xử lý data gửi từ client
                client = server.AcceptTcpClient();
                //byte[] data = server.Receive(ref clientEP);

                Thread userThread = new Thread(new ThreadStart(() => sv.User(client)));
                userThread.Start();
            }
        }


        public void User(TcpClient client)
        {
            while (true)
            {
                try
                {
                    byte[] bytes = new byte[1024];

                    NetworkStream stream = client.GetStream();

                    int i = stream.Read(bytes, 0, bytes.Length);
                    data = Encoding.ASCII.GetString(bytes, 0, i);

                    string[] code = data.Split(':');

                    switch (code[0])
                    {
                        case "play":
                            string user_id = code[1];
                            string room_no = code[2];
                            int x = Convert.ToInt32(code[3]);
                            int y = Convert.ToInt32(code[4]);
                            HandleClient.Play(user_id, room_no, x, y);
                            break;
                        case "create":
                            HandleClient.CreateRoom(code[1], code[2], client);
                            break;
                        case "join":
                            HandleClient.JoinRoom(code[1], code[2], client);
                            break;
                        //case "online":
                        //    HandleClient.UserOnline(code[1], client);
                        //    break;
                        //case "offline":
                        //    HandleClient.UserOffline(code[1]);
                        //    break;
                        case "refreshroom":
                            HandleClient.RefreshRoom();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is IOException || ex is InvalidOperationException)
                    {
                        Console.WriteLine("Client disconnected");
                        break;
                    }
                }
            }
        }
    }
}
