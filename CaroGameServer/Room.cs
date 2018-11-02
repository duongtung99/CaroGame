using System.Net;

namespace CaroGameServer
{
    class Room
    {
        public string host_id { set; get; }
        public IPAddress host_ip { set; get; }
        public string room_no { set; get; }
        public string join_id { set; get; }
        public IPAddress join_ip { set; get; }
    }
}
