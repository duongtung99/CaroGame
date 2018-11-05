using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using MySql.Data.MySqlClient;

namespace CaroGameServer
{
    class Program
    {
        // mở port listen
        private const int serverPort = 12345;
        private static UdpClient server = new UdpClient(serverPort);

        // nhận dữ liệu từ tất cả các client
        private const int clientPort = 12121;
        private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, clientPort);

        // danh sách phòng chơi
        private static List<Room> roomList = new List<Room>();

        private static void SendData(string message)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, clientEP);
        }

        #region Login
        // Thay đổi user đăng nhập từ offline thành online 
        // Chạy hàm khi CheckUser() return true
        private static void Status(string userName)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand MyCommand;
            MyCommand = conn.CreateCommand();
            conn.Open();
            try
            {
                MyCommand.CommandText = "UPDATE friendlist SET status = @status WHERE name = '" + userName + "';";
                MyCommand.Parameters.AddWithValue("@status", SqlDbType.Int).Value = 1;
                MyCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
        }

        //Kiểm tra UserName và Password
        private static bool CheckUser(string userName, string password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand MyCommand, MyCommand1;
            MyCommand = conn.CreateCommand();
            MyCommand1 = conn.CreateCommand();
            MyCommand.CommandText = "SELECT * FROM user WHERE user.userName = '" + userName + "';";
            conn.Open();
            try
            {
                MySqlDataReader reader;
                reader = MyCommand.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["password"].ToString() == password)
                    {
                        return true;
                    }
                    else
                    {
                        conn.Dispose();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Dispose();
                    conn.Close();
                    return false;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Dispose();
                conn.Close();
            }
            return false;
        }
        #endregion
        #region Test
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

        #endregion
        // tim ten doi thu 
        private static bool SearchUser(string userName)
        {


            return false;
        }


        // chạy hàm cho login
        private static void Login(string user_id, string user_pass)
        {
            // kiểm tra username và pass có trong db
            bool validate = CheckUser(user_id, user_pass);

            if (validate)
            {
                Status(user_id);
                SendData("login:true");
                Console.WriteLine("User " + user_id + " online");
            }
            else
            {
                SendData("login:false");
                Console.WriteLine("sai");
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

        private static void CreateRoom(string user_id, string room_no)
        {
            Room room = new Room
            {
                host_id = user_id,
                host_ip = clientEP.Address,
                room_no = room_no
            };

            // thêm vào danh sách room
            roomList.Add(room);

            // allow create room
            SendData("create:true");

            // log
            Console.WriteLine("User " + user_id + " create room");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Server start listening on port 12345...");

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
                    case "create":
                        CreateRoom(code[1], code[2]);
                        break;
                }
            }
        }
    }
}
