using System.Collections.Generic;
using System.Drawing;
using CaroGame.Properties;

namespace CaroGame
{
    class Main
    {
        private static int chieu_rong;
        private static int chieu_cao;

        private BanCo _BanCo;
        public Main(int chieu_rong, int chieu_cao)
        {
            _BanCo = new BanCo(chieu_rong, chieu_cao);
            Main.chieu_rong = chieu_rong;
            Main.chieu_cao = chieu_cao;
        }
        public void vebanco(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
    }
}
