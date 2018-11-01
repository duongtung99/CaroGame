using System;
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
        private static UdpClient server = new UdpClient(12345);

        // nhận dữ liệu từ tất cả các ip
        private static IPEndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);

        private static void SendData(string message)
        {
            // gửi response về client
            byte[] data = Encoding.ASCII.GetBytes(message);
            server.Send(data, data.Length, clientEP);
        }

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
                SendData("login:true");
                Console.WriteLine("dung");
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

        static void Main(string[] args)
        {
            Console.WriteLine("Server start listening on port 12345...");
            //GetUser();
            //if (CheckUser("user1","123456"))
            //{
            //    Console.WriteLine("dung");
            //    Status("user1");
            //}
            //else
            //{
            //    Console.WriteLine("sai");
            //}
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
