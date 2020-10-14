using System;
using System.Collections.Generic;
using System.Text;

namespace shurup
{
    class Circle : Figure
    {
        private int vershx, vershy, radius;

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

        public int Radius
        {
            get
            {
                return Radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(int c_vershx, int c_vershy, int c_radius)
        {
            Vershx = c_vershx;
            Vershy = c_vershy;
            radius = c_radius;
        }
        public override string Type()
        {
            return "circle";
        }

        public override bool Dot(int x, int y)
        {
            return Math.Sqrt(Math.Pow(vershx - x, 2) + Math.Pow(vershy - y, 2)) < radius;
        }
    }
}
