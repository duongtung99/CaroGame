using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;

namespace CaroGameServer
{
    class HandleClient
    {
        // danh sách phòng chơi
        private static List<Room> roomList = new List<Room>();



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
            catch (Exception ex)
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
            catch (Exception ex)
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
        public static void Login(string user_id, string user_pass)
        {
            // kiểm tra username và pass có trong db
            bool validate = CheckUser(user_id, user_pass);

            if (validate)
            {
                Server.SendData("login:true");
                Console.WriteLine("User " + user_id + " online");
            }
            else
            {
                Server.SendData("login:false");
                Console.WriteLine("sai");
            }
        }



        public static void Register(string user_id, string user_pass)
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
                Server.SendData("register:true");
            }
            else
            {
                Server.SendData("register:false");
            }
        }



        public static void CreateRoom(string user_id, string room_no, IPAddress user_ip)
        {
            Room room = new Room
            {
                host_id = user_id,
                host_ip = user_ip,
                room_no = room_no
            };

            // thêm vào danh sách room
            roomList.Add(room);

            // allow create room
            Server.SendData("create:true");

            // log
            Console.WriteLine("User " + user_id + " create room");
        }

        public static void JoinRoom(string user_id, string room_no, IPAddress user_ip)
        {
            bool check_room = false;

            foreach (Room room in roomList)
            {
                if (room.room_no.Equals(room_no))
                {
                    room.join_id = user_id;
                    room.join_ip = user_ip;

                    // gửi join thông tin của host
                    Server.SendData("join:true:" + room.host_id);

                    // gửi host thông tin của join
                    string host_message = "host:" + room.host_id + ":" + room.join_id;
                    Server.SendDataToPlayer(host_message, room.host_ip);

                    check_room = true;
                    break;
                }
            }

            if (!check_room)
            {
                Server.SendData("join:false");
            }
        }
    }
}
