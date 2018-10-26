using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CaroGameServer
{
    class Program
    {
        // mở port listen
        private static UdpClient server = new UdpClient(12345);

        // nhận dữ liệu từ tất cả các ip
        private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

        private static void SendData(string message)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, clientEP);
        }

        private static void GetUser()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand MyCommand;
            MyCommand = conn.CreateCommand();
            MyCommand.CommandText = "SELECT * FROM `user`;";
            conn.Open();
            try
            {
                MySqlDataReader reader;
                reader = MyCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"]);
                    Console.WriteLine(reader["iduser"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();
        }

        private static void Login(string user_id, string user_pass)
        {
            bool validate()
            {
                // code  lấy user_id, user_pass trong csdl ra so sánh ở đây
                // nếu user_id và user_pass chuẩn thì return true
                // nếu không chuẩn return false
                
                return false;
            }

            if (validate())
            {
                SendData("login:true");
            }
            else
            {
                SendData("login:false");
            }
        }

        private static void Register(string user_id, string user_pass)
        {
            bool validate()
            {
                // code  lấy user_id, user_pass trong csdl ra so sánh ở đây
                // nếu user_id chưa tồn tại thì lưu vào csdl rồi return true
                // nếu user_id tồn tại thì return false
                return false;
            }

            if (validate())
            {
                SendData("register:true");
            }
            else
            {
                SendData("register:false");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Server start listening on port 12345...");
            GetUser();
            while (true)
            {
                // xử lý data gửi từ client
                byte[] data = server.Receive(ref clientEP);
                string message = Encoding.ASCII.GetString(data);
                //Console.WriteLine(message);

                string[] code = message.Split(':');

                switch(code[0])
                {
                    case "play":

                        break;
                    case "login":
                        Login(code[1], code[2]);
                        break;
                    case "register":
                        Register(code[1], code[2]);
                        break;

                }
            }
        }
    }
}
