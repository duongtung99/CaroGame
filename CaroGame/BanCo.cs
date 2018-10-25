using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CaroGame
{
    class BanCo
    {
        public const int _ChieuRong = 30;
        public const int _ChieuCao = 30;

        private int _SoDong;
        private int _SoCot;

        private int _Dong;
        public int Dong
        {
            set { _Dong = value; }
            get { return _Dong; }
        }
        private int _Cot;
        private int Cot
        {
            set { _Cot = value; }
            get { return _Cot; }
        }
        public BanCo(int Socot, int Sodong)
        {
            _SoDong = Sodong;
            _SoCot = Socot;
        }
        
        public void VeBanCo(Graphics g)
        {
            for (int i = 0; i <= _SoCot; i++)
            {
                g.DrawLine(Program.pen, i * _ChieuRong, 0, i * _ChieuRong, _SoDong * _ChieuCao);
            }
            for (int j = 0; j <= _SoDong; j++)
            {
                g.DrawLine(Program.pen, 0, j * _ChieuCao, _SoCot * _ChieuRong, j * _ChieuCao);
            }
        }
        
    }
}
