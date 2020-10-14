using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Square : Figure
    {
        private int vershx, vershy, side;

        public int Vershx
        {
            get
            {
                return Vershx;
            }
            set
            {
                vershx = value;
            }
        }

        public int Vershy
        {
            get
            {
                return Vershy;
            }
            set
            {
                vershy = value;
            }
        }

        public int Side
        {
            get
            {
                return Side;
            }
            set
            {
                side = value;
            }
        }

        public Square(int s_vershx, int s_vershy, int s_side)
        {
            Vershx = s_vershx;
            Vershy = s_vershy;
            Side = s_side;
        }
        public override string Type()
        {
            return "square";
        }

        public override bool Dot(int x, int y) 
        {
            return x > vershx && x < vershx + side && y > vershy - side && y < vershy;
        }
    }
}
